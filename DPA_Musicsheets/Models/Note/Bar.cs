using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Models.Note
{
    class Bar
    {
        // 3/4 means 3 count(length) of the 4th duration
        private int Length { get; set; } //howmany counts there are 

        private Duration BaseDuration { get; set; } //which note is one count, Whole note 

        //collection of notes
        private List<Note> Notes = new List<Note>();

        private Bar Next { get => Next; set => Next = value; }
        private Bar Previous { get => Previous; set => Previous = value; }

        private Bar Repeat { get => Repeat; set => Repeat = value; }

        private Boolean repeated = false;

        public Bar()
        {
            this.Length = 4; //default
            this.BaseDuration = Duration.Whole; //default
        }

        public Bar(int length, Duration duration)
        {
            this.Length = length;
            this.BaseDuration = duration;
        }



        public void Handle()
        {
            //handle whatever notes do


            //send to next
            if (this.IsRepeat() && repeated == false)
            {
                this.repeated = true;
                this.Repeat.Handle();
            }
            else
            {
                this.Next.Handle();
            }
        }

        public Boolean IsRepeat()
        {
            return this.Repeat != null;
        }


        public Boolean IsFull(Note n = null)
        {
            int totalNoteValue = this.CalcNoteTotal();

            if(n != null)
            {
                //check size with note
                totalNoteValue += n.CalcDurationValue((int)this.BaseDuration);
            }

            return this.Length > totalNoteValue;
        }

        

        public int CalcNoteTotal()
        {
            int totalNoteValue = 0;

            foreach (Note note in this.Notes)
            {
                totalNoteValue += note.CalcDurationValue((int)this.BaseDuration);
            }

            return totalNoteValue;
        }

        public void AddNote(Note n)
        {

            if (!this.IsFull(n))
            {
                this.Notes.Add(n);
            }
            else
            {
               try { 
                    NoteFactory factory = NoteFactory.Instance;
                    int lengthLeft = this.Length - this.CalcNoteTotal();

                    this.Notes.Add(factory.CreateNote(n.Key, lengthLeft));
                    this.Next.AddNote(factory.CreateNote(n.Key, n.CalcDurationValue() - lengthLeft));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong splitting a note over two bars");
                }
            }

        }
    }
}

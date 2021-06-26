using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PrakGeneric
{
    public class VaccinationQueue<T1, T2> : IEnumerable where T2 : IComparable// T1:impfender person  T2:impf katagorie
    {

        public class Element
        {
            public T1 newPerson;
            public T2 vaccCat;
            public Element next;
            public Element(T1 newPerson, T2 vaccCat)
            {
                this.newPerson = newPerson;
                this.vaccCat = vaccCat;
                next = null;
            }
            public override string ToString()
            {
                string s = newPerson.ToString();
                s += " with prio: " + vaccCat.ToString();
                if (next!=null)
                {
                    s += " " + next.ToString();
                }
                return s;
            }

        }
        public override string ToString()
        {
            if (head==null)
            {
                throw new NoPersonException("Liste ist leer");
            }
            else
            {
                return "[" + head + "]";
            }
        }
        private Element head;
        public VaccinationQueue()
        {
            head = null;
        }
        public void RegisterPerson(T1 newPerson, T2 vaccCat)
        {
            Element neuElement = new Element(newPerson, vaccCat);
            if (head == null)
            {
                head = neuElement;
            }
            else if (vaccCat.CompareTo(head.vaccCat) < 0)
            {
                neuElement.next = head;
                head = neuElement;
            }
            else
            {
                Element temp = head;
                Element last = head;
                bool succes = false;
                while (temp != null && succes == false)
                {
                    if (vaccCat.CompareTo(temp.vaccCat) < 0)
                    {
                        last.next = neuElement;
                        neuElement.next = temp;
                        succes = true;
                    }
                    last = temp;
                    temp = temp.next;
                }
                if (succes == false)
                {
                    last.next = neuElement;
                    neuElement.next = temp;
                }
            }
        }


        public IEnumerator GetEnumerator()
        {
            Element temp = head;
            while (temp != null)
            {
                Element w = temp;

                temp = temp.next;

                yield return (w.newPerson);

            }
        }
        public Element Vaccinate()
        {
            Element temp = head;
            head = head.next;
            return temp;
        }
        public T1[] VaccinateWholeCat(T2 cat)
        {
            Element temp = head;
            int count = 0;

            while (temp != null)
            {
                if (cat.Equals(temp.vaccCat))
                {
                    count++;


                }
                temp = temp.next;
            }
            T1[] arr = new T1[count];
            Element temp2 = head;
            int counter = 0;
            while (temp2 != null)
            {
                if (cat.Equals(temp2.vaccCat))
                {

                    arr[counter++] = temp2.newPerson;


                }
                temp2 = temp2.next;
            }
            return arr;




        }
    }
}

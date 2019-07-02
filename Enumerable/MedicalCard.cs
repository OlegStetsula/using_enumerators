using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerable
{
    class MedicalCard : IEnumerable<string>
    {
        public string Heart { get; set; }
        public string Liver { get; set; }
        public string Kidneys { get; set; }

        public MedicalCard(string h, string l, string k)
        {
            Heart = h;
            Liver = l;
            Kidneys = k;
        }

        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        class Enumerator : IEnumerator<string>
        {
            MedicalCard MedCard;
            int index = 0;
            public Enumerator(MedicalCard md)
            {
                MedCard = md;
            }

            public string Current
            { get
                {
                    if (index == 1)
                        return MedCard.Heart;
                    if (index == 2)
                        return MedCard.Liver;
                    if (index == 3)
                        return MedCard.Kidneys;
                    return null;
                }
                   
            }
            public bool MoveNext()
            {
                if (index >= 0 && index < 4)
                {
                    index++;
                    return true;
                }
                return false;
            }
            public void Reset()
            {
                index = 0;
            }
            void IDisposable.Dispose()
            {
                this.Reset();
            }

            object IEnumerator.Current { get { return Current; } }
        }
    }
}

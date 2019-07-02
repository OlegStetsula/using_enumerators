using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace using_yield_return
{
    class MedicalCard
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
            yield return Heart;
            yield return Liver;
            yield return Kidneys;
        }
    }
}

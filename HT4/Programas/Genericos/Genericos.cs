namespace Genericos
{
    public class Genericos
    {
        public Genericos() { }


        public T Head<T>(T[] list)
        {
            return list[0];
        }

        
        public T[] Tail<T>(T[] list)
        {
            T[] nlist = new T[list.Length - 1];
            int co = 0;
            for (int i = 1; i < list.Length; i++)
            {
                nlist[co] = list[i];
                co += 1;
            }
            return nlist;
        }

        ///////////////////////////////////
        public Tupla<T1, T2>[] Zip<T1, T2>(T1[] lA, T2[] lB)
        {
            Tupla<T1, T2>[] arr = new Tupla<T1, T2>[longi<T1, T2>(lA, lB)];

            //////////////////////////////
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Tupla<T1, T2>(lA[i], lB[i]);
            }
            return arr;
        }

        ///////////////////////////////////////
        private int longi<T1, T2>(T1[] vA, T2[] vB)
        {
            int longi = 0;
            if (vA.Length == vB.Length)
            {
                longi = vA.Length;
            }
            else if (vA.Length > vB.Length)
            {
                longi = vB.Length;
            }
            else if (vA.Length < vB.Length)
            {
                longi = vA.Length;
            }
            return longi;
        }

        
    }
}
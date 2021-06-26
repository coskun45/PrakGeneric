using System;

namespace PrakGeneric
{
    public enum VaccCat
    {
        achtsig,
        sibsig,
        sechssigUndJunär
    };
    class Program
    {
        static void Main(string[] args)
        {
            VaccinationQueue<string, VaccCat> list = new VaccinationQueue<string, VaccCat>();
            list.RegisterPerson("Eyüp", VaccCat.achtsig);
            list.RegisterPerson("Ali", VaccCat.sechssigUndJunär);
            list.RegisterPerson("Ahmet", VaccCat.achtsig);
            list.RegisterPerson("Mehmet", VaccCat.sibsig);
            list.RegisterPerson("Veli", VaccCat.sibsig);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

           // Console.WriteLine(list.Vaccinate());
            Console.WriteLine();
            string[] arr = list.VaccinateWholeCat(VaccCat.sibsig);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            Console.WriteLine("########################################################");

            VaccinationQueue<VaccPerson, VaccCat> liste2 = new VaccinationQueue<VaccPerson, VaccCat>();
            VaccPerson p1 = new VaccPerson("Ali", "123", "Nürnberg");
            VaccPerson p2 = new VaccPerson("Bekir", "456", "schweinfurt");
            VaccPerson p3 = new VaccPerson("osman", "1789", "München");
            VaccPerson p4 = new VaccPerson("Ömer", "999", "Köln");
            liste2.RegisterPerson(p1, VaccCat.sechssigUndJunär);
            liste2.RegisterPerson(p2, VaccCat.sibsig);
            liste2.RegisterPerson(p3, VaccCat.achtsig);
            liste2.RegisterPerson(p4, VaccCat.sechssigUndJunär);

            foreach (VaccPerson item in liste2)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        private static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            LoadList();

            //System.Linq

            //firstofdefault nesne
            //where list
            //any  
            //contains 
            //exist
            //select
            //add
            //sum
            //clear
            //orderby
            //ordebydescending
            //count => sayısını verir
            //count() => istediğin koşulun countunu verir

            var s = students.FirstOrDefault(f => f.Point > 80);
            var list = students.Where(w => w.Point > 60).ToList();
            var count = students.Where(w => w.Point > 60).Count();
            var count2 = students.Count(c => c.Point > 60);
            var check = students.Any(a => a.Age == 17);


            //var student = students.FirstOrDefault(f => f.Age == 15);

            //if (student != null)
            //    students.Remove(student);


            //1.puanı 50 den büyük olup yaşı 18 den küçük olanları listele.
            //yaşı 15 den büyük eşit olanları al bunları ad sırasına göre büyükten küçüğe sırala
            //puanı 60dan büyük eşit 100 den küçk olanları listele daha sonra count al
            //tüm öğrencilerin puanlarını topla
            //sınıfı A olanların puanlarını topla
            //sınıfı c olup yaşı 17 olanların puanlarını topla

            //sınıfı A subesi olup puanı 80den kucuk esit olanların yasları toplamı
            var l7 = students.Where(a => a.ClassType == "A" && a.Point <= 80).Sum(b => b.Age);
            //B şubesindeki puanı 80den küçük ve eşit olanların isimleri uzunluklukları 
            var l8 = students.Where(a => a.ClassType == "B" && a.Point <= 80).Select(b => b.Name.Length).ToList();
            //yası 15ten buyuk olanların puanlarının kucukten buyuge sıralaması
            var l9 = students.Where(a => a.Age > 15).OrderBy(b => b.Point).ToList();
            //yası ilk 17 olan kisiyi listeden sil
            var l10 = students.FirstOrDefault(a => a.Age == 17);
            if (l10 != null)
                students.Remove(l10);




            var l1 = students.Where(a => a.Point > 50 && a.Age < 18).ToList();
            var l2 = students.Where(a => a.Age >= 15).OrderByDescending(b => b.Name).ToList();
            var l3 = students.Where(a => a.Point >= 60 && a.Point < 100).Count();
            var l4 = students.Sum(a => a.Point);
            var l5 = students.Where(a => a.ClassType == "A").Sum(b => b.Point);
            var l6 = students.Where(a => a.ClassType == "C" && a.Age == 17).Sum(b => b.Point);



            //var grp = students.GroupBy(a => new { a.ClassType, a.Age })
            //                  .Select(se => new
            //                  {
            //                      Sinif = se.Key.ClassType,
            //                      Yas = se.Key.Age,
            //                      Elamanlar = se.ToList()
            //                  })
            //                  .ToList();

            //Take()

            ////linq foreach
            //foreach (var item in grp)
            //{
            //    if (item.Yas == 17)
            //        continue;

            //    //işlemler
            //}


            //grp.ForEach(f =>
            //{


            //});
           
        }

        private static void LoadList()
        {
            var st1 = new Student("Ali", "Yilmaz", "A", 80, 17);
            var st2 = new Student("Veli", "Yildiz", "B", 75, 18);
            var st3 = new Student("Ahmet", "Koc", "C", 60, 15);
            var st4 = new Student("Mehmet", "Sabanci", "B", 68, 16);
            var st5 = new Student("Karahan", "Turker", "A", 60, 17);
            var st6 = new Student("Mauro", "Icardi", "B", 90, 18);
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);
            students.Add(st6);
        }

    }
}
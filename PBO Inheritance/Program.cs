using System;

namespace TUGASPBO3
{
    class Processor
    {
        public string merk;
        public string tipe;

    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core i3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core i5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core i7";
        }
    }
    class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }

    class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    class VGA
    {
        public string merk;

    }

    class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    class AMDVga : VGA
    {
        public AMDVga()
        {
            base.merk = "AMD";
        }
    }

    class Laptop
    {
        public string merk;
        public string tipe;
        public VGA vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }

    }
    class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "Ideapad";
        }
    }

    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new AMDVga();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator.vga = new AMDVga();
            predator.processor = new Corei7();


            // SOAL 1. Jalankan method LaptopDinyalakan() dan LaptopDimatikan() pada laptop2!
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            // SOAL 2. Jalankan method Ngoding() pada laptop1.
            //laptop1.Ngoding();

            // SOAL 3. Menampilkan di console spesifikasi (merk vga, merk processor, tipe processor)apa yang digunakan laptop1
            //Console.WriteLine($"Merk Vga = {laptop1.vga.merk}\n" + $"Merk Processor = {laptop1.processor.merk}\n" + $"Tipe Processor = {laptop1.processor.tipe}");

            // SOAL 4. Jalankan method BermainGame() pada predator
            //predator.BermainGame();

            //SOAL 5. Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan
            //objek Predator sebagai nilainya. Jalankan method BermainGame() pada acer.
            //ACER acer = new Predator();
            //((Predator)acer).BermainGame();
        }
    }
}



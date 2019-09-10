using System;

using System.Net;



namespace Terning

{



    public delegate int FindTilfældigTerningVærdiDelegate();



    class Program

    {

        static void Main(string[] args)

        {

            Terning01 t = new Terning01();

            for (int i = 0; i < 5; i++)

            {

                t.Ryst();

                Console.WriteLine(t);

            }

            Console.WriteLine();

            // Terning02

            FindTilfældigTerningVærdiDelegate f = TilfældigTerningVærdiMock;

            Terning02 t2 = new Terning02(f);

            for (int i = 0; i < 5; i++)

            {

                t2.Ryst();

                Console.WriteLine(t2);

            }



            Console.WriteLine();

            // Terning03                        

            Terning03 t3 = new Terning03(TilfældigTerningVærdiRandomOrg);

            for (int i = 0; i < 5; i++)

            {

                t3.Ryst();

                Console.WriteLine(t3);

            }



            Console.WriteLine();

            // Terning04                        

            //Terning04 t4 = new Terning04(() => 6);

            //Terning04 t4 = new Terning04(() => new Random().Next(1,7));

            Terning04 t4 = new Terning04(() => {

                WebClient w = new WebClient();

                return Convert.ToInt32(w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new"));

            });

            for (int i = 0; i < 5; i++)

            {

                t4.Ryst();

                Console.WriteLine(t4);

            }





        }



        static int TilfældigTerningVærdi()
        {

            return Convert.ToInt32(new Random().Next(1, 7));

        }



        static int TilfældigTerningVærdiRandomOrg()

        {

            WebClient w = new WebClient();

            return Convert.ToInt32(w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new"));

        }



        static int TilfældigTerningVærdiMock()

        {

            return 6;

        }

    }





    class Terning01

    {



        public int Værdi { get; private set; }



        public void Ryst()
        {

            this.Værdi = (new Random()).Next(1, 7);

        }



        public override string ToString()

        {

            return $"[{this.Værdi}]";

        }



        public Terning01()

        {

            this.Ryst();

        }



    }



    class Terning02

    {



        public int Værdi { get; private set; }

        private FindTilfældigTerningVærdiDelegate func;



        public void Ryst()

        {

            this.Værdi = func();

        }



        public override string ToString()

        {

            return $"[{this.Værdi}]";

        }



        public Terning02(FindTilfældigTerningVærdiDelegate func)

        {

            this.func = func;

            this.Ryst();

        }



    }



    class Terning03

    {



        public int Værdi { get; private set; }

        private Func<int> func;



        public void Ryst()

        {

            this.Værdi = func();

        }



        public override string ToString()

        {

            return $"[{this.Værdi}]";

        }



        public Terning03(Func<int> func)

        {

            this.func = func;

            this.Ryst();

        }



    }



    class Terning04

    {



        public int Værdi { get; private set; }

        private Func<int> func;



        public void Ryst()

        {

            this.Værdi = func();

        }



        public override string ToString()

        {

            return $"[{this.Værdi}]";

        }



        public Terning04(Func<int> func)

        {

            this.func = func;

            this.Ryst();

        }



    }

}


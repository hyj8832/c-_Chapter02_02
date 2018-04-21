using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class Program
    {
        public int SumAll(params int[] aNumbers)//params:매개변수가 몇개든지 ㅎㅎㅎ허용 aNumbers배열로 받기 때문에.
        {
            int i;
            int tmp = 0;
            for (i = 0; i < aNumbers.Length; i++)
            {
                tmp += aNumbers[i];

            }
            return (tmp);
        }

        public void SelectCard(int aNumber, string aShape)//aNumber만 값 주고, 뒤에 거 안주면 안돼. 무조건 aNumber줄거면 aShape도 줘야하고,,,,,
                                                          //aNumber값주고, 매개변수로 aShape줘도 안돼.
        {
            Console.WriteLine("Shape:{0},Number:{1}", aShape, aNumber % 13 + 1);
        }

        public void MakeCard(int aNumber, string aShape = "Diamond")
        {
            Console.WriteLine("Shape:{0},Number:{1}", aShape, aNumber % 13 + 1);
        }


        static void Main(string[] args)
        {
            Program tmpC = new Program();
            int total1 = tmpC.SumAll(1, 2);
            int total2 = tmpC.SumAll(1, 2, 3, 4, 5);
            int total3 = tmpC.SumAll(1, 2, 3, 4, 5);
            //int total3 = tmpC.SumAll(new int[]{1, 2});이렇게 쓰면 params필요없다.

            Console.WriteLine(total1);
            Console.WriteLine(total2);
            Console.WriteLine(total3);
            //va_list 이거 알아두장..

            int[] param4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total4 = tmpC.SumAll(param4);
            Console.WriteLine(total4);

            tmpC.SelectCard(10, "Diamond"); //순서는 달라도 되지만 명칭을 주어 알려줘야해!
            tmpC.SelectCard(aNumber: 12, aShape: "Diamond");
            tmpC.SelectCard(aShape: "Heart", aNumber: 12);

            tmpC.MakeCard(7);
            tmpC.MakeCard(10, "Heart");//다이아몬드라고 정해져 있지만 내가 정한 값이 나옴.

            CSmartPhone tmpSP1 = new CSmartPhone();
            CSmartPhone tmpSP2 = new CSamsungPhone();//자식으로 생성하고 부모로 받았어 업캐스팅
            CSmartPhone tmpSP3 = new CLGPhone();

            Console.WriteLine(tmpSP1.GetMarket());
            Console.WriteLine(tmpSP2.GetMarket());
            Console.WriteLine(tmpSP3.GetMarket());

            Console.WriteLine(tmpSP1.GetButtonCount());
            Console.WriteLine(tmpSP2.GetButtonCount());
            Console.WriteLine(tmpSP3.GetButtonCount());

            if (tmpSP2 is CSamsungPhone)//is는 자바의 instanceof와 비슷한 아이 
            {
                CSamsungPhone tmpSP4 = (CSamsungPhone)tmpSP2;
                Console.WriteLine(tmpSP4.GetButtonCount());
            }

            CLGPhone tmpSP5 = tmpSP3 as CLGPhone; //as:형변환과 같다고 생각해 tmpSP3을 엘지폰으로 !
            // CLGPhone tmpSP5 = (CLGPhone)tmpSP3 ;와 동일

            //is 와 as알기 !!
            if (tmpSP5 != null)
            {
                Console.WriteLine(tmpSP5.GetButtonCount());
            }

            CSmartPhone tmpSP7 = new CSmartPhone();
            CSmartPhone tmpSP8 = new CSmartPhone();
            CSmartPhone tmpSP9;
            UseSmartPhone(tmpSP7);
            ChargeSmartPhone(ref tmpSP8);//ref:객체일 경우 생성이 되어있어야 해 꼭
            MakeSmartPhone(out tmpSP9);

            Console.WriteLine(tmpSP7.theID);
            Console.WriteLine(tmpSP8.theID);
            Console.WriteLine(tmpSP9.theID);
        }
        static void UseSmartPhone(CSmartPhone aPhone)
        {
            aPhone.theID = "Use";
        }
        static void ChargeSmartPhone(ref CSmartPhone aPhone)
        {
            aPhone.theID = "Charge";
        }
        static void MakeSmartPhone(out CSmartPhone aPhone) //매개변수에out이 붙었다면 객체라면 이 안에서 생성꼭 해줘야 한다.
        {
            aPhone = new CSmartPhone();
            aPhone.theID = "Make";
        }
    }
}

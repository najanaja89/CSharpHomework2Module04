using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework2Module04
{
   public partial class Rocket
    {
        private string flyType;
        private string engineType;
        private int flyRadius;
        private string warheadType;
        private string navigateType;

        private static int countOfRockets =0;

        public Rocket()
        {
            name = "test";
            flyType = "ballistic";
            engineType = "solid fuel";
            flyRadius = 1000;
            warheadType = "nuclear";
            navigateType = "ray";

        }

        public Rocket(string name, string flyType, string engineType, int flyRadius, string warheadType, string navigateType)
        {
            this.name = name;
            this.flyType = flyType;
            this.engineType = engineType;
            this.flyRadius =  flyRadius;
            this.warheadType = warheadType;
            this.navigateType = navigateType;

        }

        static Rocket()
        {
            countOfRockets++;
        }


        //Методы доступа к приватным переменным.
        public void SetFlyType(string flyType)
        {
            this.flyType = flyType;
        }

        public void SetEngineType(string engineType)
        {
            this.engineType = engineType;
        }


        public void SetFlyRadius(int flyRadius)
        {
            this.flyRadius = flyRadius;
        }

        public string GetFlyType()
        {
            return flyType;
        }

        public string GetEngineType()
        {
            return engineType;
        }

        public int GetFlyRadius()
        {
            return flyRadius;
        }


        //Передача аргумента по ссылке.
        public void SetWarHeadType(ref string warheadType)
        {
            this.warheadType = warheadType;
        }

        public string GetWarHeadType()
        {
            return warheadType;
        }

        //Перегрузка операторов.
        public static Rocket operator +(Rocket r1, Rocket r2)
        {
            return new Rocket
            {
                engineType = r1.engineType + ", " + r2.engineType,
                flyType = r1.flyType + ", " + r2.flyType,
                navigateType = r1.navigateType + ", " + r2.navigateType
            };
        }

        public static bool operator !=(Rocket r1, Rocket r2)
        {
            return !(r1.engineType == r2.engineType && r1.flyType == r2.flyType && r1.navigateType == r2.navigateType);
        }

        public static bool operator ==(Rocket r1, Rocket r2)
        {
            return (r1.engineType == r2.engineType && r1.flyType == r2.flyType && r1.navigateType == r2.navigateType);
        }

    }
}

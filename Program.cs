namespace BitGetable
{


    //    public class Device : IControllable
    //    {
    //        public bool IsOn { get; private set; } = false;
    //        public void On()
    //        {
    //            IsOn = true;
    //        }
    //        public void Off()
    //        {
    //            IsOn = false;
    //        }
    //    }
    //        public interface IControllable
    //    {
    //        bool IsOn { get; }
    //        void On();
    //        void Off();
    //    }

    //    public class Devices
    //    {
    //        public List<IControllable> DevicesList { get; init; }
    //        public Devices()
    //        {
    //            DevicesList =
    //            [
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            new Device(),
    //            ];
    //        }

    //        public void TurnOnOff(Bits bits)
    //        {
    //            for (byte i = 0; i < 8; i++)
    //            {
    //                if (DevicesList[i].IsOn && !bits[i])
    //                    DevicesList[i].Off();
    //                else if (!DevicesList[i].IsOn && bits[i])
    //                    DevicesList[i].On();
    //            }
    //        }

    //        public override string ToString()
    //        {
    //            return string.Join("", DevicesList.Select(s => s.IsOn ? "1" : "0"));
    //        }
    //    }
    public class Program
    {
        private static void Main(string[] args)
        {
            Matrix<int> array = new Matrix<int>(2, 2);

            array[0, 0] = 1;
            array[0, 1] = 2;
            array[1, 0] = 4;
            array[1, 1] = 5;

            array.PrintMatrix();
        }
    }
}

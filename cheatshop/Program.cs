class Program
{
    static void Main(string[] args)
    {
        var list = new List<byte>();
        int pointer1 = 1;
        int pointer2 = 2;
        int pointer3 = 3;
        int pointer4 = 4;
        int pointer5 = 5;
        int pointer6 = 6;
        int pointer7 = 7;
        int pointer8 = 8;
        bool patched = false;
        byte[] price = { 255, 255, 255, 255 };
        byte[] by = File.ReadAllBytes(args[0]);

        int startPointer = 9739572;
        bool end = false;
        int readPointer = startPointer;
        while (!end)
        {
            if (readPointer > 10906472)
            {
                end = true;
            }

            if (BitConverter.ToInt32(by, readPointer) == 10000000 || BitConverter.ToInt32(by, readPointer) == 5000000)
            {
                by[readPointer + 0] = 1;
                by[readPointer + 1] = 0;
                by[readPointer + 2] = 0;
                by[readPointer + 3] = 0;
            }
            readPointer = readPointer + 4;
        }


        if (args[0].Length > 0)
        {
            //by = File.ReadAllBytes(args[0]);
            //if (BitConverter.ToInt32(by, 0) != 442919021)
            //    return;

            list = by.ToList();
            byte[] devide = { 00, 00, 00, 00 };
            int increment = 0;

            int firstPointer = BitConverter.ToInt32(by, 196);   //C76D60
            pointer1 = BitConverter.ToInt32(by, firstPointer + 0);
            pointer2 = BitConverter.ToInt32(by, firstPointer + 4);
            pointer3 = BitConverter.ToInt32(by, firstPointer + 8);
            pointer4 = BitConverter.ToInt32(by, firstPointer + 12);
            pointer5 = BitConverter.ToInt32(by, firstPointer + 16);
            pointer6 = BitConverter.ToInt32(by, firstPointer + 20);
            pointer7 = BitConverter.ToInt32(by, firstPointer + 24);
            pointer8 = BitConverter.ToInt32(by, firstPointer + 28);

            byte[] data = File.ReadAllBytes("data/1_katate");
            byte[] length = BitConverter.GetBytes(list.Count);
            WriteLength(increment, length);
            list.AddRange(data);

            data = File.ReadAllBytes("data/12_slash");
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/2_dual");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);

            data = File.ReadAllBytes("data/13_tonfa");
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/3_great");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);

            data = File.ReadAllBytes("data/14_senryuu");
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/4_tachi");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/5_hammer");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/6_horn");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/7_lance");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/8_gance");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/9_light");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/10_heavy");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            data = File.ReadAllBytes("data/11_bow");
            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            list.AddRange(data);
            list.AddRange(devide);

            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            byte[] data1 = File.ReadAllBytes("data/a_head.bin");
            list.AddRange(data1);
            list.AddRange(devide);

            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            data1 = File.ReadAllBytes("data/b_chest.bin");
            list.AddRange(data1);
            list.AddRange(devide);

            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            data1 = File.ReadAllBytes("data/c_arms.bin");
            list.AddRange(data1);
            list.AddRange(devide);

            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            data1 = File.ReadAllBytes("data/d_waist.bin");
            list.AddRange(data1);
            list.AddRange(devide);

            length = BitConverter.GetBytes(list.Count);
            WriteLength(increment = increment + 4, length);
            data1 = File.ReadAllBytes("data/e_legs.bin");
            list.AddRange(data1);
            list.AddRange(devide);

            File.WriteAllBytes("mhfdat.bin", list.ToArray());
            Console.WriteLine("Patch completed.");
            Console.ReadKey();

            void WriteLength(int add, byte[] length)
            {
                list[pointer1 + add] = length[0];
                list[pointer1 + add + 1] = length[1];
                list[pointer1 + add + 2] = length[2];
                list[pointer1 + add + 3] = length[3];
                list[pointer2 + add] = length[0];
                list[pointer2 + add + 1] = length[1];
                list[pointer2 + add + 2] = length[2];
                list[pointer2 + add + 3] = length[3];
                list[pointer3 + add] = length[0];
                list[pointer3 + add + 1] = length[1];
                list[pointer3 + add + 2] = length[2];
                list[pointer3 + add + 3] = length[3];
                list[pointer4 + add] = length[0];
                list[pointer4 + add + 1] = length[1];
                list[pointer4 + add + 2] = length[2];
                list[pointer4 + add + 3] = length[3];
                list[pointer5 + add] = length[0];
                list[pointer5 + add + 1] = length[1];
                list[pointer5 + add + 2] = length[2];
                list[pointer5 + add + 3] = length[3];
                list[pointer6 + add] = length[0];
                list[pointer6 + add + 1] = length[1];
                list[pointer6 + add + 2] = length[2];
                list[pointer6 + add + 3] = length[3];
                list[pointer7 + add] = length[0];
                list[pointer7 + add + 1] = length[1];
                list[pointer7 + add + 2] = length[2];
                list[pointer7 + add + 3] = length[3];
                list[pointer8 + add] = length[0];
                list[pointer8 + add + 1] = length[1];
                list[pointer8 + add + 2] = length[2];
                list[pointer8 + add + 3] = length[3];
            }
        }
    }
}



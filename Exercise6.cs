using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
	  //������� 6 * ��� ������� ����������� ������� �����, ����������� ������� ������������� ��������� ���������� ������, � �������, ����� ������� ������ ������ ���� �����. ����� ������ - ���� ����� 1 �������� �� �������� �� �������, ���� ����� 2 �������� � ������������ �� ����������� � �������� ��� �� ����� �������.
            string Monday = "�����������: � 8:00 �� 18:00";
            string Tuesday = "�������: � 8:00 �� 18:00";
            string Wednesday = "�����:   � 8:00 �� 18:00";
            string Thursday = "�������: � 8:00 �� 18:00";
            string Friday = "�������: � 8:00 �� 18:00";
            string Saturday = "�������: � 8:00 �� 18:00";
            string Sunday = "�����������: � 8:00 �� 18:00";

            Console.Write("������� ����� ����� (1 ��� 2): ");
            int office = Convert.ToInt32(Console.ReadLine());

            if (office == 1)
            {
                Console.WriteLine($"����� ������ ����� �1:\n {Tuesday}\n {Wednesday}\n {Thursday}\n {Friday}");
            }

            else if (office == 2)
            {
                Console.WriteLine($"����� ������ ����� �2:\n {Monday}\n {Tuesday}\n {Wednesday}\n {Thursday}\n {Friday}\n {Saturday}\n {Sunday}");
            }

            else
            {

            }
	}
    }
}
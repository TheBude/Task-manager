string[] vazifa = new string[10];
bool[] bajarilganVazifa = new bool[10];
int vazifalarSoni = 0;

while (true)
{
    Console.WriteLine("1. Vazifa Qo'shish");
    Console.WriteLine("2. Vazifa olib tashlash");
    Console.WriteLine("3. Bajarilgan vazifalar deb belgilash");
    Console.WriteLine("4. Vazifalar Ruyxatini ko'rsatish");
    Console.WriteLine("5. Dasturdan chiqish");
    Console.Write("Amalarni bajarish uchun (1-5) gacha kiriting:  ");
    string enterNumber = Console.ReadLine();

    switch (enterNumber)
    {
        case "1":
            if (vazifa.Length > vazifalarSoni)
            {
                Console.WriteLine("Yangi vazifani kiriting");
                string yangiVazifa = Console.ReadLine();
                vazifa[vazifalarSoni] = yangiVazifa;
                bajarilganVazifa[vazifalarSoni] = false;
                vazifalarSoni++;
                Console.WriteLine("Vazifa muvfoqiyatli Qo'shildi!");
            }
            else
            {
                Console.WriteLine("Uzur topa olmadim 🙄");
            }
            break;

        case "2":
            Console.Write("O'chirilishi kerak bo'lgan vazifa raqamini kiriting: ");
            int deleteVazifa = Convert.ToInt32(Console.ReadLine()) - 1;
            if (deleteVazifa >= 0 && deleteVazifa < vazifalarSoni)
            {
                for (int i = deleteVazifa; i < vazifalarSoni - 1; i++)
                {
                    vazifa[i] = vazifa[i + 1];
                    bajarilganVazifa[i] = bajarilganVazifa[i + 1];
                }
                vazifalarSoni--;
                Console.WriteLine("Muvfoqiyatli o'chirildi");
            }
            else
            {
                Console.WriteLine("Uzur topa olmadim 🙄");
            }
            break;

        case "3":
            Console.Write("Qaysi vazifani bajarilgan deb belgilamoqchisiz: ");
            int complete = Convert.ToInt32(Console.ReadLine()) - 1;
            if (complete >= 0 && complete < vazifalarSoni)
            {
                bajarilganVazifa[complete] = true;
                Console.WriteLine("Vazifa bajarilgan deb belgilandi");
            }
            else
            {
                Console.WriteLine("Uzur topa olmadim 🙄");
            }
            break;
        case "4":
            Console.WriteLine("Vazifalar jadvali\n");

            if (vazifalarSoni == 0)
            {
                Console.WriteLine("Hozircha vazifalar Yuq");
            }
            else
            {
                for (int i = 0; i < vazifalarSoni; i++)
                {
                    Console.WriteLine($"{i + 1}. {vazifa[i]} - {(bajarilganVazifa[i] ? "Bajarildi" : "Bajarilmadi")}");
                }
            }
            break;

        case "5": // Dasturdan chiqish
            return;

        default:
            Console.WriteLine("Noto'g'ri tanlov. Iltimos, 1 dan 5 gacha bo'lgan raqamni kiriting.");
            break;
    }
}
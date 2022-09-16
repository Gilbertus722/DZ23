Console.Write("Число: ");
int vg = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int vg){
    
    int counter = Convert.ToString(vg).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = vg - vg % 10;
      result = result + (vg - advance);
      vg = vg / 10;
    }
   return result;
  }

int sumNumber = SumNumber(vg);
Console.WriteLine("Сумма цифр: " + sumNumber);

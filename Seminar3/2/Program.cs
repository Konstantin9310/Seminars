/*
Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).
*/




void Print(string text){
    
    Console.WriteLine(text);
  
}

int GetItNumber(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindCoordinate(int number){
    if(number > 0 && number < 5){
     
        switch (number)
        {
            case 1: Print ("x > 0, y > 0");
            break;
            
            case 2: Print ("x < 0, y > 0");
            break;

            case 3: Print ("x < 0, y < 0 ");
            break;

            case 4: Print ("x > 0, y < 0");
            break;

        }
    }
    else{
        Print("insert correct number");
    }
}

    
Print("Input quarter");
int number = GetItNumber();

FindCoordinate(number);

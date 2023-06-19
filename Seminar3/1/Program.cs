string data = "data";
string error = "error";
string result = "result";

void Print(string text, string arg){
    switch (arg)
    {
    case "data": Console.ForegroundColor = ConsoleColor.Yellow;    
    break;       
    
    case "result": Console.ForegroundColor = ConsoleColor.Green;    
    break;   
    case "error": Console.ForegroundColor = ConsoleColor.Red;    
    break;   

    }
    Console.WriteLine(text);
    Console.ResetColor();
}

int GetItNum(){
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FindQuarter(int x, int y){
    if(x == 0 || y == 0){
        Print("Our or bouth coordinate equal 0", error);
    }
    else {
        switch ((x, y))
        {
            case (>0, >0): Print ("First quarter.", result);
            break;
            
            case (<0, >0): Print ("Second quarter.", result);
            break;

            case (<0, <0): Print ("Third quarter.", result);
            break;

            case (>0, <0): Print ("Fourth quarter.", result);
            break;

        }
    }
}
    
Print("Input X coordinate", data);
int coordinateX = GetItNum();

Print("Input Y coordinate", data);
int coordinateY = GetItNum();

//Print($"Our Coordinate X = {coordinateX}, Y = {coordinateY} data");

FindQuarter(coordinateX, coordinateY);
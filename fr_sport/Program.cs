int poäng   =0;
string omstart="";
string question="";

while (omstart =="ja")
  {
    while (question !="a"&&question!="b"&&question!="c"&&question!="d")
    {
        Console.WriteLine("vilken skola går Tommi på?");
        Console.WriteLine("a)NTI b)cyber c)Norra real ");
        question =Console.ReadLine();
        
            if(question=="a")
            {
                poäng++;
                Console.WriteLine("bra jobbat du hade rätt");
                question="d";
            
            }
            else if(question =="c"|| question=="b")
            {
                Console.WriteLine("nope fel svar");
                question="d";
            }
            
            else
            {
                Console.WriteLine("svara a,b eller c");
                question="";
            }
        }
        while (question !="a"&&question!="b"&&question!="c"&&question!="e")
    {
        Console.WriteLine("har tin en stor keps");
        Console.WriteLine("a)Nej b)Ja c)kuggfråga tin har ingen keps ");
        question=Console.ReadLine();

        if (question=="b")
        {    poäng++;
            Console.WriteLine("du har rätt");
            question ="e";
        }
        else if(question=="a"||question=="b")
        {
            Console.WriteLine("du är dumhuvud");
            question="e";
        }
        else{
            Console.WriteLine("svara a,b eller c");
            question="";
        }    
    }
        while (question !="a"&&question!="b"&&question!="c"&&question!="f")
        {
        Console.WriteLine("How many holes in a polo?");
        Console.WriteLine("a)2 b)3 c)4");

        question=Console.ReadLine();

            if (question=="b")
            {    poäng++;
                Console.WriteLine("wow du hade rätt");
                question ="f";
            }
            else if(question=="a"||question=="c")
            {
                Console.WriteLine("nah fel");
                question="f";
            }
            else{
                Console.WriteLine("svara a,b eller c");
                question="";
            }  
           

            while (omstart != "ja"&& omstart!= "nej" )  
            {
            Console.WriteLine($"Wow, du fick {poäng} vill du starta om?");
            omstart = Console.ReadLine();
            
            
            if (omstart == "ja")
            {
                omstart="ja";
            }
            else if (omstart =="nej")
            {
                Console.WriteLine("synd");
            }
            else{
                Console.WriteLine("svara med ja eller nej");

            }
        }
    }
  }
Console.ReadLine();
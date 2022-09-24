int point =0;

string question="";



    while (question !="a"&&question!="b"&&question!="c"&&question!="d")
    {
        Console.WriteLine("vilken skola går Tommi på?");
        Console.WriteLine("a)NTI b)cyber c)Norra real ");
        question =Console.ReadLine();
        
            if(question=="a")
            {
                point++;
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
        Console.WriteLine("har tin en stor keps?");
        Console.WriteLine("a)Nej b)Ja c)kuggfråga tin har ingen keps ");
        question=Console.ReadLine();

        if (question=="b")
        {    point++;
            Console.WriteLine("du har rätt");
            question ="e";
        }
        else if(question=="c"||question=="a")
        {
            Console.WriteLine("lmao fel");
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

            if (question=="c")
            {    point++;
                Console.WriteLine("wow du hade rätt");
                question ="f";
            }
            else if(question=="a"||question=="b")
            {
                Console.WriteLine("nah fel");
                question="f";
            }
            else{
                Console.WriteLine("svara a,b eller c");
                question="";
            }  
           
            
        
            Console.WriteLine($"Wow, du fick {point} poäng. Ha det bra!");
            
       
        }
    
  
Console.ReadLine();
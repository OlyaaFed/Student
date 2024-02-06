using _1;



List<STUDENT> students = new List<STUDENT>();

for (int i = 0;i < 2; i++)
{
    STUDENT stud = new STUDENT();
    stud.InToScreen();
    students.Add(stud);
}
int norma = 3;
int norma2 = 4;



foreach (STUDENT stud in students)

    if (stud.Math <= norma || stud.Math <= norma2)
    {
        stud.OutToScreen();
    }
    else
    {
        if (stud.Russkyi <= norma || stud.Russkyi <= norma2)
        {
            stud.OutToScreen();
        }
        else
        {
            if (stud.Fhysic <= norma || stud.Fhysic <= norma2)
            {
                stud.OutToScreen();
            }
            else
            {
                if (stud.Fhysic <= norma || stud.Fhysic <= norma2)
                {
                    stud.OutToScreen();
                }
                else
                {
                    if (stud.Biology <= norma || stud.Biology <= norma2)
                    {
                        stud.OutToScreen();
                    }
                    else
                    {
                        if (stud.Deuthlang <= norma || stud.Deuthlang <= norma2)
                        {
                            stud.OutToScreen();
                        }
                        if (stud.Deuthlang == 5 && stud.Math == 5 && stud.Russkyi == 5 && stud.Biology == 5 && stud.Fhysic == 5)
                        {
                          
                            Console.WriteLine($"{stud.Nameofstud} - Отличник");
                        }
                      
                    }
                }
            }
        }
    }
     
foreach( STUDENT stud in students)
    stud.ToString();








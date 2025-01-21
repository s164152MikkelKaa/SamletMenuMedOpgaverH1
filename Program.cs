using System.Globalization;

namespace SamletMenuMedOpgaverH1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theProgramStage = 0;
            while (theProgramStage >= 0)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tSamlet menu med opgaver.");
                Console.WriteLine("\t\tHovedmenuen:");
                Console.WriteLine();
                Console.WriteLine("\tIndtast indikatoren for det ønskede menupunkt.");
                Console.WriteLine();
                Console.WriteLine("\t1) Begynderopgaver menuen.");
                Console.WriteLine("\t2) Rutinerede opgaver menuen.");
                Console.WriteLine("\t3) Avancerede opgaver menuen.");
                Console.WriteLine();
                Console.WriteLine("\tQ) Afslut programmet.");
                Console.Write("\t");
                theProgramStage = ReadMainMenueInput();
                switch (theProgramStage)
                {
                    case -1:
                        // End program case.
                        break;
                    case 1:
                        theProgramStage = SubmenueBasic();
                        break;
                    case 2:
                        theProgramStage = 0;
                        break;
                    case 3:
                        theProgramStage = 0;
                        break;
                    default:
                        // Error protection and display main menue again.
                        theProgramStage = 0;
                        break;
                }
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tProgrammet er afsluttet, tryk på en tast.");
            Console.Write("\t");
            Console.ReadKey(true);
        }

        private static int ReadMainMenueInput()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Q:
                    return -1;
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    return 3;
                default:
                    return 0;
            }
        }

        private static int SubMenueInputHandeler(int maxInputValue)
        {
            string? theInput;
            int theInputValue;
            theInput = Console.ReadLine();
            theInput = theInput ?? "";
            if (theInput == "Q" || theInput == "q") {
                // Exit program.
                return -2;
            } else if (theInput == "R" || theInput == "r") {
                // Return to main menue.
                return -1;
            } else if (int.TryParse(theInput, out theInputValue)) {
                if (theInputValue >= 1 && theInputValue <= maxInputValue) {
                    return theInputValue;
                } else {
                    Console.WriteLine("\tDet indtastede indikator var ikke på menuen, tryk på en tast for at fortsætte.");
                    Console.Write("\t");
                    Console.ReadKey(true);
                }
            } else {
                Console.WriteLine("\tDet indtastede kunne ikke forstås, tryk på en tast for at fortsætte.");
                Console.Write("\t");
                Console.ReadKey(true);
            }
            // Stay on the same menue, no selection was made.
            return 0;
        }

        private static int SubmenueBasic()
        {
            int theSubmenueStage = 0;
            while (theSubmenueStage >= 0)
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tSamlet menu med opgaver.");
                Console.WriteLine("\t\tBegynderopgaver menu:");
                Console.WriteLine();
                Console.WriteLine("\tIndtast indikatoren for det ønskede menupunkt og afslut med enter.");
                Console.WriteLine();
                Console.WriteLine("\t 1) Hej Verden.");
                Console.WriteLine("\t 2) Simple Variable.");
                Console.WriteLine("\t 3) Grundlæggende Matematiske Operationer.");
                Console.WriteLine("\t 4) If-else Struktur med Alder.");
                Console.WriteLine("\t 5) Fahrenheit til Celsius.");
                Console.WriteLine("\t 6) Lommeregner.");
                Console.WriteLine("\t 7) Brugerdefinerede Metoder.");
                Console.WriteLine("\t 8) Loop Eksempel - For Løkke.");
                Console.WriteLine("\t 9) Simple Arrays.");
                Console.WriteLine("\t10) Multi-dimentionelle Arrays.");
                Console.WriteLine("\t11) Konstanter.");
                Console.WriteLine("\t12) E-mail Validering.");
                Console.WriteLine("\t13) Fejlretning. *?*"); // How to include this?
                Console.WriteLine("\t14) Opretning og Brug af Kommentarer. *?*"); // Whats supposed to go here?
                Console.WriteLine("\t15) Tal Rækkefølge.");
                Console.WriteLine("\t16) Grundlæggende BMI-beregner.");
                Console.WriteLine("\t17) String Formattering.");
                Console.WriteLine("\t18) Talgenkendelse med Løkker.");
                Console.WriteLine("\t19) Grunding af Versionsstyring. *?*"); // "introduce practical use throughout the assignment"... how?
                Console.WriteLine("\t20) Basis Login System.");
                Console.WriteLine();
                Console.WriteLine("\t R) Returner til hovedmenu.");
                Console.WriteLine("\t Q) Afslut programmet.");
                Console.Write("\t");
                theSubmenueStage = SubMenueInputHandeler(20);
                if (theSubmenueStage > 0) {
                    Console.ResetColor();
                    Console.Clear();
                }
                switch (theSubmenueStage)
                {
                    case 1:
                        Console.WriteLine("Hej Verden");
                        break;
                    case 2:
                        string theName = "Mikkel";
                        Console.WriteLine(theName);
                        break;
                    case 3:
                        string theInputCase3_1, theInputCase3_2;
                        double theConvertedInputCase3_1, theConvertedInputCase3_2, tempResult;
                        Console.WriteLine("Indtast det første tal, afslut med enter.");
                        theInputCase3_1 = Console.ReadLine();
                        Console.WriteLine("Indtast det andet tal, afslut med enter.");
                        theInputCase3_2 = Console.ReadLine();
                        Console.WriteLine();
                        if (double.TryParse(theInputCase3_1, out theConvertedInputCase3_1) && double.TryParse(theInputCase3_2, out theConvertedInputCase3_2)) {
                            tempResult = theConvertedInputCase3_1 + theConvertedInputCase3_2;
                            Console.WriteLine($"Resultatet af addition: {tempResult}");
                            tempResult = theConvertedInputCase3_1 - theConvertedInputCase3_2;
                            Console.WriteLine($"Resultatet af subtraktion: {tempResult}");
                            tempResult = theConvertedInputCase3_1 * theConvertedInputCase3_2;
                            Console.WriteLine($"Resultatet af multiplikation: {tempResult}");
                            if (theConvertedInputCase3_2 != 0.0) {
                                tempResult = theConvertedInputCase3_1 / theConvertedInputCase3_2;
                                Console.WriteLine($"Resultatet af division: {tempResult}");
                            } else {
                                Console.WriteLine($"Kan ikke udføre division, da divisoren er 0.");
                            }
                        } else {
                            Console.WriteLine("Det indtastede kunne ikke forstås som tal.");
                        }
                        break;
                    case 4:
                        string theInputCase4;
                        int theConvertedInputCase4;
                        Console.WriteLine("Indtast din alder og afslut med enter.");
                        theInputCase4 = Console.ReadLine();
                        if (int.TryParse(theInputCase4, out theConvertedInputCase4)) {
                            if (theConvertedInputCase4 < 0) {
                                Console.WriteLine("Din alder kan ikke være negativ.");
                            } else if (theConvertedInputCase4 < 18) {
                                Console.WriteLine("Du er ikke myndig.");
                            } else {
                                Console.WriteLine("Du er myndig.");
                            }
                        } else {
                            Console.WriteLine("Det indtastede kunne ikke oversættes til et heltal.");
                        }
                        break;
                    case 5:
                        string theInputCase5;
                        double theConvertedInputCase5, theCalculationResultCase5;
                        Console.WriteLine("Indtast en temperatur i Fahrenheit for at omregne den til Celsius, afslut indtastningen med enter.");
                        theInputCase5 = Console.ReadLine();
                        if (double.TryParse(theInputCase5, out theConvertedInputCase5)) {
                            theCalculationResultCase5 = (theConvertedInputCase5 - 32.0) / 1.8;
                            Console.WriteLine($"Resultatet er: {theCalculationResultCase5 : N1} C");
                        } else {
                            Console.WriteLine("Det indtastede kunne ikke forstås som et tal.");
                        }
                        break;
                    case 6:
                        string theInputCase6Operator, theInputCase6Number1, theInputCase6Number2;
                        double theConvertedInput1Case6, theConvertedInput2Case6;
                        bool inputTjekCase6 = true;
                        Console.WriteLine("Indtast en af de følgende operatore og afslut med enter: + - * /");
                        theInputCase6Operator = Console.ReadLine();
                        switch (theInputCase6Operator)
                        {
                            case "+":
                                Console.WriteLine("Indtast det første tal og afslut med enter.");
                                theInputCase6Number1 = Console.ReadLine();
                                Console.WriteLine("Indtast det andet tal og afslut med enter.");
                                theInputCase6Number2 = Console.ReadLine();
                                if (double.TryParse(theInputCase6Number1, out theConvertedInput1Case6) && double.TryParse(theInputCase6Number2, out theConvertedInput2Case6)) {
                                    Console.WriteLine($"Resultatet af addition er: {theConvertedInput1Case6 + theConvertedInput2Case6}");
                                } else {
                                    Console.WriteLine("De indtastede tal kunne ikke læses som tal.");
                                }
                                break;
                            case "-":
                                Console.WriteLine("Indtast det første tal og afslut med enter.");
                                theInputCase6Number1 = Console.ReadLine();
                                Console.WriteLine("Indtast det andet tal og afslut med enter.");
                                theInputCase6Number2 = Console.ReadLine();
                                if (double.TryParse(theInputCase6Number1, out theConvertedInput1Case6) && double.TryParse(theInputCase6Number2, out theConvertedInput2Case6)) {
                                    Console.WriteLine($"Resultatet af subtraktion er: {theConvertedInput1Case6 - theConvertedInput2Case6}");
                                } else {
                                    Console.WriteLine("De indtastede tal kunne ikke læses som tal.");
                                }
                                break;
                            case "*":
                                Console.WriteLine("Indtast det første tal og afslut med enter.");
                                theInputCase6Number1 = Console.ReadLine();
                                Console.WriteLine("Indtast det andet tal og afslut med enter.");
                                theInputCase6Number2 = Console.ReadLine();
                                if (double.TryParse(theInputCase6Number1, out theConvertedInput1Case6) && double.TryParse(theInputCase6Number2, out theConvertedInput2Case6)) {
                                    Console.WriteLine($"Resultatet af multiplikation er: {theConvertedInput1Case6 * theConvertedInput2Case6}");
                                } else {
                                    Console.WriteLine("De indtastede tal kunne ikke læses som tal.");
                                }
                                break;
                            case "/":
                                Console.WriteLine("Indtast det første tal og afslut med enter.");
                                theInputCase6Number1 = Console.ReadLine();
                                Console.WriteLine("Indtast det andet tal og afslut med enter.");
                                theInputCase6Number2 = Console.ReadLine();
                                if (double.TryParse(theInputCase6Number1, out theConvertedInput1Case6) && double.TryParse(theInputCase6Number2, out theConvertedInput2Case6)) {
                                    if (theConvertedInput2Case6 != 0.0) {
                                        Console.WriteLine($"Resultatet af division er: {theConvertedInput1Case6 / theConvertedInput2Case6}");
                                    } else {
                                        Console.WriteLine("Kan ikke udføre division, da divisoren er 0.");
                                    }
                                } else {
                                    Console.WriteLine("De indtastede tal kunne ikke læses som tal.");
                                }
                                break;
                            default:
                                Console.WriteLine("Den indtastede operator blev ikke genkendt.");
                                break;
                        }
                        break;
                    case 7:
                        UserDefinedMethodsSimpleCase7();
                        break;
                    case 8:
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.Write(i);
                            if (i < 10) {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case 9:
                        string[] strArrCase9 = { "jordbær", "stikkelsbær", "brombær" };
                        foreach (string arrElement in strArrCase9)
                        {
                            Console.WriteLine(arrElement);
                        }
                        break;
                    case 10:
                        int[,] numArraysCase10 = { { 20, 3850 }, { 70000, 123456 } };
                        Console.WriteLine($"\t{numArraysCase10[0, 0],7}\t{numArraysCase10[0, 1],7}");
                        Console.WriteLine($"\t{numArraysCase10[1, 0],7}\t{numArraysCase10[1, 1],7}");
                        break;
                    case 11:
                        // "VAT" = "Value Added Tax" = (DK) "Moms".
                        const double VATCase11 = 0.25;
                        Console.WriteLine("Indtast din pris uden moms og afslut med enter.");
                        // theConvertedInputCase11 = theInConvCase11.
                        if (double.TryParse(Console.ReadLine(), out double theInConvCase11)) {
                            Console.Write("Moms af ");
                            Console.Write(theInConvCase11.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                            Console.Write(" er ");
                            Console.Write((theInConvCase11 * VATCase11).ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                            Console.Write(" som samlet giver ");
                            Console.WriteLine((theInConvCase11 * (1.0 + VATCase11)).ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
                        } else {
                            Console.WriteLine("Det indtastede kunne ikke forstås som et tal.");
                        }
                        break;
                    case 12:
                        string theInputCase12;
                        int theIndex1Case12, theIndex2Case12;
                        Console.WriteLine("Indtast din e-mail og afslut med enter.");
                        theInputCase12 = Console.ReadLine();
                        theInputCase12 = theInputCase12.Trim();
                        theIndex1Case12 = theInputCase12.IndexOf('@');
                        theIndex2Case12 = theInputCase12.LastIndexOf('.');
                        // Test condition 1: The e-mail contains a '@' character and it isn't the first character.
                        // Test condition 2: The e-mail contains a '.' character, it comes after the '@' character and have atleast 1 other character in betwene them.
                        // Test condition 3: '.' isn't the last character.
                        // Test condition 4: There are no spaces in the string (after the .Trim() method).
                        if (theIndex1Case12 > 0 && theIndex2Case12 > theIndex1Case12 + 1 && theIndex2Case12 < theInputCase12.Length - 1 && !theInputCase12.Contains(' ')) {
                            Console.WriteLine("Den indtastede e-mail gennemførte testende.");
                        } else {
                            Console.WriteLine("Den indtastede e-mail testede ikke korrekt.");
                        }
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        bool theInTesterCase15;
                        double[] theConvNumInCase15 = new double[3];
                        Console.WriteLine("Indtast det første tal og afslut med enter.");
                        theInTesterCase15 = double.TryParse(Console.ReadLine(), out theConvNumInCase15[0]);
                        Console.WriteLine("Indtast det andet tal og afslut med enter.");
                        theInTesterCase15 = theInTesterCase15 && double.TryParse(Console.ReadLine(), out theConvNumInCase15[1]);
                        Console.WriteLine("Indtast det tredje tal og afslut med enter.");
                        if (theInTesterCase15 && double.TryParse(Console.ReadLine(), out theConvNumInCase15[2])) {
                            theConvNumInCase15 = theConvNumInCase15.Order().ToArray();
                            foreach (double currentNumber in theConvNumInCase15)
                            {
                                Console.WriteLine(currentNumber);
                            }
                        } else {
                            Console.WriteLine("Et eller flere af de indtastede tal kunne ikke forstås.");
                        }
                        break;
                    case 16:
                        bool theInTesterCase16;
                        double theInHeightCase16, theInWeightCase16, theResCase16;
                        Console.WriteLine("Indtast din højde i meter og afslut med enter.");
                        theInTesterCase16 = double.TryParse(Console.ReadLine(), out theInHeightCase16);
                        Console.WriteLine("Indtast din vægt i kilo og afslut med enter.");
                        if (theInTesterCase16 && double.TryParse(Console.ReadLine(), out theInWeightCase16)) {
                            theResCase16 = theInWeightCase16 / (theInHeightCase16 * theInHeightCase16);
                            Console.WriteLine($"Det beregnede BMI er: {theResCase16:N2}");
                        } else {
                            Console.WriteLine("Det indtastede kunne ikke forstås som tal.");
                        }
                        break;
                    case 17:
                        string theInNameCase17;
                        int theInAgeCase17;
                        Console.WriteLine("Indtast dit navn og afslut med enter.");
                        theInNameCase17 = Console.ReadLine();
                        Console.WriteLine("Indtast din alder og afslut med enter.");
                        if (int.TryParse(Console.ReadLine(), out theInAgeCase17)) {
                            Console.WriteLine($"Dit navn er {theInNameCase17} og din alder er {theInAgeCase17} år.");
                        } else {
                            Console.WriteLine("Den indtastede alder var ikke et tal.");
                        }
                        break;
                    case 18:
                        int theNumberCase18 = 7, theInNumCase18;
                        string theInStrCase18;
                        bool theRunConditionCase18 = true;
                        while (theRunConditionCase18)
                        {
                            Console.WriteLine("Gæt det hemmelige tal.");
                            Console.WriteLine("Indtast et tal fra 1 til 10 (1 og 10 med) og afslut med enter.");
                            Console.WriteLine("Indtast \"R\" og afslut med enter, for at returnere til menuen.");
                            theInStrCase18 = Console.ReadLine();
                            if (theInStrCase18 == "R" || theInStrCase18 == "r") {
                                theSubmenueStage = 0;
                                theRunConditionCase18 = false;
                            } else if (int.TryParse(theInStrCase18, out theInNumCase18)) {
                                if (theInNumCase18 > 0 && theInNumCase18 < 11) {
                                    if (theInNumCase18 == theNumberCase18) {
                                        Console.WriteLine("Du har gættet det hemmelige tal, tillykke, returnere til menuen.");
                                        theRunConditionCase18 = false;
                                    } else {
                                        Console.WriteLine("Du har gættet forkert, tryk på en tast for at prøve igen.");
                                        Console.ReadKey(true);
                                        Console.Clear();
                                    }
                                } else {
                                    Console.WriteLine("Det indtastede tal er uden for det givende værdiområde, tryk på en tast for at prøve igen.");
                                    Console.ReadKey(true);
                                    Console.Clear();
                                }
                            } else {
                                Console.WriteLine("Det indtastede blev ikke forstået, tryk på en tast for at prøve igen.");
                                Console.ReadKey(true);
                                Console.Clear();
                            }
                        }
                        break;
                    case 19:
                        Console.WriteLine("Versionsstyring.");
                        Console.WriteLine("Versionsstyring.");
                        break;
                    case 20:
                        string theInUsernameCase20, theInPasswordCase20;
                        string theCorUsernameCase20 = "Mikkel418";
                        string theCorPasswordCase20 = "I am a teapot";
                        Console.WriteLine("Indtast dit brugernavn og afslut med enter.");
                        theInUsernameCase20 = Console.ReadLine();
                        Console.WriteLine("Indtast dit kodeord og afslut med enter.");
                        theInPasswordCase20 = Console.ReadLine();
                        if (theInUsernameCase20 == theCorUsernameCase20 && theInPasswordCase20 == theCorPasswordCase20) {
                            Console.WriteLine($"Velkommen {theInUsernameCase20}.");
                        } else {
                            Console.WriteLine("Brugernavn eller adgangskode var forkert.");
                        }
                        break;
                    default:
                        break;
                }
                if (theSubmenueStage > 0) {
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en tast for at gå tilbage til menuen.");
                    Console.ReadKey(true);
                    theSubmenueStage = 0;
                }
            }
            return (theSubmenueStage == -1 ? 0 : -1);
        }

        private static void UserDefinedMethodsSimpleCase7()
        {
            Console.WriteLine("Velkommen til stedet.");
        }

        private static int SubmenueIntermedeate()
        {
            int theSubmenueStage = 0;
            while (theSubmenueStage >= 0)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\t\tSamlet menu med opgaver.");
                Console.WriteLine("\t\tBegynderopgaver menu:");
                Console.WriteLine();
                Console.WriteLine("\tIndtast indikatoren for det ønskede menupunkt og afslut med enter.");
                Console.WriteLine();
                Console.WriteLine("\t 1) .");
                Console.WriteLine("\t 2) .");
                Console.WriteLine("\t 3) .");
                Console.WriteLine("\t 4) .");
                Console.WriteLine("\t 5) .");
                Console.WriteLine("\t 6) .");
                Console.WriteLine("\t 7) .");
                Console.WriteLine("\t 8) .");
                Console.WriteLine("\t 9) .");
                Console.WriteLine("\t10) .");
                Console.WriteLine("\t11) .");
                Console.WriteLine("\t12) .");
                Console.WriteLine("\t13) .");
                Console.WriteLine("\t14) .");
                Console.WriteLine("\t15) .");
                Console.WriteLine("\t16) .");
                Console.WriteLine("\t17) .");
                Console.WriteLine("\t18) .");
                Console.WriteLine("\t19) .");
                Console.WriteLine("\t20) .");
                Console.WriteLine();
                Console.WriteLine("\t R) Returner til hovedmenu.");
                Console.WriteLine("\t Q) Afslut programmet.");
                Console.Write("\t");
                theSubmenueStage = SubMenueInputHandeler(20);
                if (theSubmenueStage > 0) {
                    Console.ResetColor();
                    Console.Clear();
                }
                switch (theSubmenueStage)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    default:
                        break;
                }
                if (theSubmenueStage > 0) {
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en tast for at gå tilbage til menuen.");
                    Console.ReadKey(true);
                    theSubmenueStage = 0;
                }
            }
            return (theSubmenueStage == -1 ? 0 : -1);
        }

        private static int SubmenueAdvanced()
        {
            int theSubmenueStage = 0;
            while (theSubmenueStage >= 0)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\t\tSamlet menu med opgaver.");
                Console.WriteLine("\t\tBegynderopgaver menu:");
                Console.WriteLine();
                Console.WriteLine("\tIndtast indikatoren for det ønskede menupunkt og afslut med enter.");
                Console.WriteLine();
                Console.WriteLine("\t 1) .");
                Console.WriteLine("\t 2) .");
                Console.WriteLine("\t 3) .");
                Console.WriteLine("\t 4) .");
                Console.WriteLine("\t 5) .");
                Console.WriteLine();
                Console.WriteLine("\t R) Returner til hovedmenu.");
                Console.WriteLine("\t Q) Afslut programmet.");
                Console.Write("\t");
                theSubmenueStage = SubMenueInputHandeler(5);
                if (theSubmenueStage > 0) {
                    Console.ResetColor();
                    Console.Clear();
                }
                switch (theSubmenueStage)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                if (theSubmenueStage > 0) {
                    Console.WriteLine();
                    Console.WriteLine("Tryk på en tast for at gå tilbage til menuen.");
                    Console.ReadKey(true);
                    theSubmenueStage = 0;
                }
            }
            return (theSubmenueStage == -1 ? 0 : -1);
        }
    }
}

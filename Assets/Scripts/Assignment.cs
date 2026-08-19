using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // As01_CheckNumberSign();
        // As02_GetDayName();
        // As03_ValidatePassword();
        // As04_GetGrade();
        // As05_IsLeapYear();
        // As06_Calculate();
        // As07_GetSeason();
        // As08_PurchasingSystemExample();
        // As09_RockPaperScissorsExample();
        As10_CalculateWeaponDamage();
        // As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        // throw new System.NotImplementedException();

        if (as01Number > 0) //มากกว่า 0
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0) //น้อยกว่า 0
        {
            Debug.Log("Negative");
        }
        else //เท่ากับ 0
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        //throw new System.NotImplementedException();

        if (as02Day == 1) //หากตัวเลขเป็น 1 ให้แสดงผลเป็น Monday
        {
            Debug.Log("Monday");
        }
        else if (as02Day == 2) //หากตัวเลขเป็น 2 ให้แสดงผลเป็น Tuesday
        {
            Debug.Log("Tuesday");
        }
        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
        else //หากตัวเลขไม่อยู่ในช่วง 1-7 ให้แสดงผลเป็น Invalid day
        {
            Debug.Log("Invalid day");
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");
        // throw new System.NotImplementedException();

        if (as03InputPassword == as03CorrectPassword) 
        {
            Debug.Log("You have accessed"); //หากรหัสผ่านตรงกัน ให้แสดงผลเป็น You have accessed
        }
        else //หากรหัสผ่านไม่ตรงกัน ให้แสดงผลเป็น You are Guest
        {
            Debug.Log("You are Guest");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        //throw new System.NotImplementedException();

        if (as04Score >= 80) //หากคะแนนมากกว่าหรือเท่ากับ 80 ให้แสดงผลเป็น Grade A
        {
            Debug.Log("Grade A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("Grade B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("Grade C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("Grade D");
        }
        else //หากคะแนนน้อยกว่า 50 ให้แสดงผลเป็น Grade F
        {
            Debug.Log("Grade F");
        }
       
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");
        //throw new System.NotImplementedException();

        if (as05Year % 400 == 0) //หากปีนั้นหารด้วย 400 ลงตัว ให้แสดงผลเป็น Leap Year
        {
            Debug.Log("Leap Year"); 
        }
        else if (as05Year % 100 == 0) //หากปีนั้นหารด้วย 100 ลงตัว ให้แสดงผลเป็น Not a Leap Year
        {
            Debug.Log("Not a Leap Year"); 
        }
        else if (as05Year % 4 == 0) //หากปีนั้นหารด้วย 4 ลงตัว ให้แสดงผลเป็น Leap Year
        {
            Debug.Log("Leap Year"); 
        }
        else //หากปีนั้นไม่ตรงตามเงื่อนไขใด ๆ ให้แสดงผลเป็น Not a Leap Year
        {
            Debug.Log("Not a Leap Year");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");
        // throw new System.NotImplementedException();

        double result = 0; //ตัวแปรสำหรับเก็บผลลัพธ์ของการคำนวณ

        switch (as06Op)
        {
            case '+': //หากเครื่องหมายเป็น + ให้ทำการบวกเลขทั้งสองตัว
                result = as06Num1 + as06Num2;
                break;

            case '/':
                if (as06Num2 == 0) //ตรวจสอบว่าตัวหารเป็น 0 หรือไม่ หากเป็น 0 ให้แสดงผลเป็น Error: Division by zero
                {
                    Debug.Log("Error: Division by zero");
                }
                else
                {
                    result = as06Num1 / as06Num2; //หากตัวหารไม่เป็น 0 ให้ทำการหารเลขทั้งสองตัว
                }
                break;

            default: //หากเครื่องหมายไม่ตรงตามเงื่อนไขใด ๆ ให้แสดงผลเป็น Error: Invalid operator
                Debug.Log("Error: Invalid operator, Please use +,-,*, or /.");
                return;
        }
        Debug.Log($"Result: {result}"); //แสดงผลลัพธ์ของการคำนวณ
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        // throw new System.NotImplementedException();
        if (as07Month >= 1 && as07Month <= 12) 
        {
            if (as07Month == 12 || as07Month == 1 || as07Month == 2) //หากเดือนเป็น 12, 1, หรือ 2 ให้แสดงผลเป็น Winter
            {
                Debug.Log("Winter");
            }
            else if (as07Month >= 3 && as07Month <= 5) //หากเดือนเป็น 3, 4, หรือ 5 ให้แสดงผลเป็น Spring
            {
                Debug.Log("Spring");
            }
            else if (as07Month >= 6 && as07Month <= 8) //หากเดือนเป็น 6, 7, หรือ 8 ให้แสดงผลเป็น Summer
            {
                Debug.Log("Summer");
            }
            else if (as07Month >= 9 && as07Month <= 11) //หากเดือนเป็น 9, 10, หรือ 11 ให้แสดงผลเป็น Fall
            {
                Debug.Log("Fall");
            }
            else //หากเดือนไม่อยู่ในช่วง 1-12 ให้แสดงผลเป็น Invalid month
            {
                Debug.Log("Invalid month number. Please enter a number between 1 and 12.");
            }
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        //throw new System.NotImplementedException();

        // ตรวจสอบสินค้าใน stock
        if (as08Quantity <= 0)
        {
            Debug.Log("สินค้าหมด");
        }
        else
        {
            // กรณีมีสินค้าใน stock (as08Quantity > 0)
            if (as08Payment >= as08Price)
            {
                Debug.Log("คุณได้รับสินค้าแล้ว");

                // หากมีเงินทอน (as08Payment > as08Price)
                if (as08Payment > as08Price)
                {
                    Debug.Log($"คุณได้รับเงินทอน {as08Payment - as08Price} บาท"); //แสดงผลเงินทอน (as08Payment - as08Price)
                }
            }
            else
            {
                // กรณีเงินไม่พอ (as08Payment < as08Price)
                Debug.Log("คุณมีเงินไม่พอ");
            }
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        //throw new System.NotImplementedException();

        if (as09UserChoice == 1 && as09ComputerChoice == 1) //หากผู้เล่นเลือก 1 และคอมพิวเตอร์เลือก 1 ให้แสดงผลเป็น Draw
        {
            Debug.Log("Draw");
        }
        else if (as09UserChoice == 1 && as09ComputerChoice == 2) //หากผู้เล่นเลือก 1 และคอมพิวเตอร์เลือก 2 ให้แสดงผลเป็น You Lose
        {
            Debug.Log("You Lose");
        }
        else if (as09UserChoice == 1 && as09ComputerChoice == 3) //หากผู้เล่นเลือก 1 และคอมพิวเตอร์เลือก 3 ให้แสดงผลเป็น You Win
        {
            Debug.Log("You Win");
        }
        else if (as09UserChoice == 2 && as09ComputerChoice == 1) 
        {
            Debug.Log("You Win");
        }
        else if (as09UserChoice == 2 && as09ComputerChoice == 2) 
        {
            Debug.Log("Draw");
        }
        else if (as09UserChoice == 2 && as09ComputerChoice == 3) 
        {
            Debug.Log("You Lose");
        }
        else if (as09UserChoice == 3 && as09ComputerChoice == 1) 
        {
            Debug.Log("You Lose");
        }
        else if (as09UserChoice == 3 && as09ComputerChoice == 2) 
        {
            Debug.Log("You Win");
        }
        else if (as09UserChoice == 3 && as09ComputerChoice == 3) 
        {
            Debug.Log("Draw");
        }
        else //หากผู้เล่นเลือกตัวเลขที่ไม่ใช่ 1, 2, หรือ 3 ให้แสดงผลเป็น Please 1,2,3
        {
            Debug.Log("Please 1,2,3");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        //throw new System.NotImplementedException();

        double multiplier = 1.0; //ตัวคูณความเสียหายเริ่มต้นเป็น 1.0
        switch (as10WeaponType?.ToLower() //เปลี่ยนค่า as10WeaponType เป็นตัวพิมพ์เล็กเพื่อให้สามารถตรวจสอบได้อย่างถูกต้อง
            )
        {
            case "sword": //หากอาวุธเป็น sword ให้ตัวคูณความเสียหายเป็น 1.5
                multiplier = 1.5;
                break;
            case "bow": //หากอาวุธเป็น bow ให้ตัวคูณความเสียหายเป็น 1.2
                multiplier = 1.2;
                break;
            case "staff":
                multiplier = 1.5;
                break;
            case "dagger":
                multiplier = 1.1;
                break;
            case "axe":
                multiplier = 1.4;
                break;
            default: //หากอาวุธไม่ตรงตามเงื่อนไขใด ๆ ให้ตัวคูณความเสียหายเป็น 1.0
                multiplier = 1.0;
                break;
            
        }
        int TotalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log(TotalDamage.ToString());
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        //throw new System.NotImplementedException();

        if (as11Score < 0 || as11CompletionTime < 0) //หากคะแนนหรือเวลาที่ใช้ในการทำภารกิจเป็นค่าลบ ให้แสดงผลเป็น Invalid score or time
        {
            Debug.Log("Invalid score or time"); //แสดงผล Invalid score or time
            return;
        }
        string rank; int baseCoins; //ตัวแปรสำหรับเก็บอันดับและจำนวนเหรียญพื้นฐาน
        if (as11Score >= 8000) 
        { 
            rank = "Gold"; baseCoins = 100; 
        }
        else if (as11Score >= 6000) //หากคะแนนมากกว่าหรือเท่ากับ 6000 ให้กำหนดอันดับเป็น Silver และจำนวนเหรียญพื้นฐานเป็น 75
        {
            rank = "Silver"; baseCoins = 75;
        }
        else if (as11Score >= 4000)
        {
            rank = "Bronze"; baseCoins = 50;
        }
        else //หากคะแนนน้อยกว่า 4000 ให้กำหนดอันดับเป็น Participation และจำนวนเหรียญพื้นฐานเป็น 25
        {
            rank = "Participation"; baseCoins = 25;
        }

        int timeBonus = 0;
        if (as11CompletionTime <= 30) timeBonus = 25; //หากเวลาที่ใช้ในการทำภารกิจน้อยกว่าหรือเท่ากับ 30 วินาที ให้กำหนดโบนัสเวลาเป็น 25
        else if (as11CompletionTime <= 60) timeBonus = 15;

        int totalCoins = baseCoins + timeBonus;
        Debug.Log($"{rank} Rank - {totalCoins} coins earned!");
    }
}

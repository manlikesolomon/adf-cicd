﻿// See https://aka.ms/new-console-template for more information

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
// string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;


// foreach (string ip in ipv4Input)
// {
//     address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
//     ValidateLength();
//     ValidateZeroes();
//     ValidateRange();

//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"c{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
// }


// void ValidateLength() 
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() 
// {
//     foreach (string number in address) 
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
TellFortune();

void TellFortune()
{
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"{text[i]} {fortune[i]}");
    }
}



















double c= -5; //The start temperatur
    while (c <=40) { //The max temperatur
        double f=c*9/5+32; //The formula for temperatur from celcius to fahrenheit
    Console.WriteLine("{0,5:F1}°C {1,5:f1}°F", c, f); //The degrees between 0,5° to 1,5°

c+= 0.5;
}

//double c=-5;
do {
double f = c*9/5+32;

    Console.WriteLine("{0,5:F1}°C {1,5:f1}°F", c, f);
    c+=0.5;
    } while (c <=40);
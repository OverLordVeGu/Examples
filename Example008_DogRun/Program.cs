﻿Console.Clear ();
int count = 0;
int distance = 20;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int Friend = 2;
int time = 0;

while (distance > 10) 
{
    if (Friend == 1) {
        time = distance / (firstFriendSpeed + dogSpeed);
        Friend = 2;
    }
    else {
        time = distance / (secondFriendSpeed + dogSpeed);
        Friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count ++;
}
Console.Write ("Собака пробежала ");
Console.WriteLine (count);
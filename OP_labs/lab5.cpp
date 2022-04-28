#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

int main() {
    setlocale(LC_ALL, "Russian");

    long n;
    long counter = 0;
    long p = 1;


    cout << "Введiть кiлькiсть простих чисел для виводу: ";
    cin >> n;

    bool noError = n > 0 && !cin.fail();
    bool prime;

    if (noError) {
        while (counter < n) {
            
            prime = true;
            if (p == 1) {
                prime = false;
            }
            for (int i = 2; i * i <= p; i++) {
                if (p % i == 0) {
                    prime = false;
                }
            }
            if (prime) {
                cout << p << endl;
                
                counter++;

            }
            p++;
        }
    }
}

   


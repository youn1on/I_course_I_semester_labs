#include <iostream>
#include <string>
#include <cmath>

using namespace std;

int n;
bool init();
float calculateArea(float a, float b, float alpha);
float solution();
void browse();

int main() {
    setlocale(LC_ALL, "Russian");
    if (init()) {
        browse();
    }
}

bool init() {
    cout << "Введiть кiлькiсть трикутникiв" << endl;
    cin >> n;
    return !cin.fail();
}

float calculateArea(float a, float b, float alpha) {
    return 0.5 * a * b * sin(alpha);
}

float solution() {
    bool noError = !cin.fail();
    float a, b, alpha;
    float maxArea = 0;
    
    for (int i = 0; i < n; i++) {
        cout << "Введiть першу, другу сторону i кут мiж ними" << endl;
        cin >> a >> b >> alpha;
        if (noError) {
            if (maxArea < calculateArea(a, b, alpha)) {
                maxArea = calculateArea(a, b, alpha);
            }
        }
        else {
            system("cls");
        }
    }
    return maxArea;
}

void browse() {
    cout << solution();
}

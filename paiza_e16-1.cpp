#include <iostream>
using namespace std;
int main() {
    int a, b, c;
    cin >> a >> b >> c;

    int n = 0;
    n += a;
    n *= b;
    n %= c;
    cout << n << endl;
}

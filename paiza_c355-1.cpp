#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int int_data,a,b;

    for(int i=0;i<2;i++){
        cin >> int_data;
        if(i == 0){
            a = int_data;
        } else if (i == 1){
            b = int_data;
        }
    }

    cout << a - b << endl;
    return 0;
}

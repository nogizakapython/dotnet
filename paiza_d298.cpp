#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    string str1,str2;
    int num1,num2;
    cin >> str1;
    cin >> str2;
    num1 = str1.length();
    num2 = str2.length();
    if(num1==num2){
        cout << "Yes" << endl;
    }else{
        cout << "No" << endl;
    }
    return 0;
}

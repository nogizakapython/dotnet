#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    for(int i=1;i<=100;i++){
        if((i % 3 == 0) && (i % 5 == 0)){
            cout << "FizzBuzz" << endl;
        } else if (i % 3 == 0){
            cout << "Fizz" << endl;
        } else if ( i % 5 == 0 ){
            cout << "Buzz" << endl;
        } else {
            cout << i << endl;
        }
    }
    
    return 0;
}
#include <iostream>
using namespace std;
int main(void){
    // 自分の得意な言語で
    // Let's チャレンジ！！
    int num;
    int max_t = 0;
    for(int i=0;i<3;i++){
        cin >> num;
        if(num >= max_t){
            max_t = num;
        }
    }
    cout << max_t << endl;
    return 0;
}
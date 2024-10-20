#include<iostream>
using namespace std;

int main(){
    string a, b;
    cin >> a >> b;
    string answer = "";
    if(a == b){
        answer = "OK";
    }else{
        answer = "NG";
    }
    cout << answer << endl;
    return 0;
}

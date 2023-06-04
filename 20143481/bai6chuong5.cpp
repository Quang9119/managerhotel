#include<iostream>
using namespace std;
int cal(int n);

int main()
{
	int n;
	cin >>n;
	int kq = cal(n);
	cout <<kq;
	return 0;
}

int cal(int n)
{
		if(n==0)return 0;
		if(n==1)return 1;
		if(n%2==0){
			return cal(n/2);
		}else{
			return cal(n/2) + cal(n/2+1);
		}
}

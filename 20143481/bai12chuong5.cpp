#include <iostream>
using namespace std;
void nhap(int &n);
void hoanvi(int n);
void hoandoi(int &x,int &y);
void daochuoi(int s[],int x, int y);
void xuat(int s[],int n);

int main() {
	int n;
	nhap(n);
	hoanvi(n);
	return 0;
}
void nhap(int &n) {
	cout << "Nhap n : ";
	cin>> n;
}
void hoanvi(int n) {
	int s[n+1];
	for(int i=1;i<=n;i++) {
		s[i]=i;
	}
	xuat(s,n);
	while(true) {
		int m=n-1;
		int k=n;
		while(s[m]>s[m+1]) {
			m--;
		}
		if(m<=0) {
			break;
		}
		while(s[k]<s[m]) {
			k--;
		}
		hoandoi(s[m],s[k]);
		daochuoi(s,m+1,n);
		xuat(s,n);
	}
}
void hoandoi(int &x,int &y) {
	int t=x;
	x=y;
	y=t;
}
void daochuoi(int s[],int x, int y) {
	while(x<y) {
		hoandoi(s[x],s[y]);
		x++;
		y--;
	}
}
void xuat(int s[],int n) {
	for(int i=1;i<=n;i++) {
		cout << s[i];
	}
	cout << endl;
}

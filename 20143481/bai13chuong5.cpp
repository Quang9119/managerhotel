#include <iostream>
using namespace std;
void nhap(int &m, int &n);
void hoanvi(int m, int n);
void xuat(int s[],int m);

int main() {
	int m,n;
	nhap(m,n);
	hoanvi(m,n);
	return 0;
}
void nhap(int &m, int &n) {
	do {
		cout << "Nhap m va n (m<=n) : ";
		cin >> m >> n;
	}while(m>n||m<=0||n<=0);
}
void hoanvi(int m, int n) {
	int s[m+1];
	int i;
	for(i=1;i<=m;i++) {
		s[i]=i;
	}
	xuat(s,m);
	while(true) {
		i=m;
		while(s[i]==n-m+i) {
			i--;
		}
		if(i==0) {
			break;
		}
		s[i]++;
		for(int j=i+1;j<=m;j++) {
			s[j]=s[j-1]+1;
		}
		xuat(s,m);
	}
}
void xuat(int s[],int m) {
	for(int i=1;i<=m;i++) {
		cout << s[i];
	}
	cout << endl;
}

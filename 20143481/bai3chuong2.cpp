#include <iostream>
using namespace std;
void nhap(int A[],int &n);
void themxoasua(int A[],int &n);

int main()
{
	int A[100],n;
	nhap(A,n);
	themxoasua(A,n);
	return 0;
}
void nhap(int A[],int &n)
{
	cin >> n ;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
void them(int A[],int &n,int x)
{
	int vitri;
	cout << "Nhap vi tri them :";
	cin >> vitri;
	cout << "Nhap gia tri them :";
	cin >>x;
	for(int i=n;i>vitri;i--)
	{
		A[i]=A[i-1];
	}
	A[vitri]=x;
	n++;
}
void xoa(int A[],int &n,int x)
{
	cout << "Nhap gia tri muon xoa :";
	cin >> x;
	int vitri;
	for(int i=0;i<n;i++)
	{
		if(A[i]==x)
		{
			vitri=i;
			break;
		}
	}
	for(int i=vitri;i<=n-2;i++)
	{
		A[i]=A[i+1];
	}
	n--;
}
void sua(int A[],int n,int x)
{
	int vitri;
	cout << "Nhap vi tri so sua : ";
	cin >> vitri;
	cout << "Nhap gia tri sua :";
	cin >> x;
	A[vitri]=x;
}
void tim(int A[],int n,int x)
{
	bool check =0;
	cout << "Nhap gia tri muon tim :";
	cin >> x;
	for(int i=0;i<n;i++)
	{
		if(A[i]==x)
		{
			check =1;
			cout << "Co gia tri vua nhap trong mang"<< " vi tri " << i << endl;
		}
	}
	if(check =0)
	cout << "Khong co gia tri vua nhap trong mang " << endl;
}
void themxoasua(int A[],int &n)
{
	int x;
	cout << "Chon thu tuc tren ham : " << endl;
	cout << "1.Them" << endl;
	cout << "2.Xoa" << endl;
	cout << "3.Sua" << endl;
	cout << "4.Timkiem" << endl;
	cout << "5.Thoat " << endl;
	int choose;
	cin >> choose;
	if(choose == 1)
	{
		them(A,n,x);
	}
	if(choose ==2)
	{
		xoa(A,n,x);
	}
	if(choose ==3)
	{
		sua(A,n,x);
	}
	if(choose ==4 )
	{
		tim(A,n,x);
	}
	if(choose ==5)
	{
		exit(0);
	}
	cout << "Mang sau khi chinh sua la : " << endl;
	for(int i=0;i<n;i++) {
		cout << A[i] << " ";
	}
	cout << endl;
	themxoasua(A,n);
}

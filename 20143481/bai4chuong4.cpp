#include <iostream>
using namespace std;
int timvitri(int k,int trai,int phai);

int A[100];
int main()
{
	int n,k;
	cin >> n >> k;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
	int vitri = timvitri(k,0,n-1);
	cout <<vitri;
	return 0;
}
int timvitri(int k,int trai,int phai)
{
	if(trai ==phai)
	{
		if(A[trai]==k)
		{
			return trai;
		}
		else
		{
			return -1;
		}
	}
	else
	{
		int giua = (trai+phai)/2;
		if(A[giua]==k)
		{
			return giua;
		}
		else if(A[giua]>k)
		{
			timvitri(k,trai,giua-1);
		}
		else
		{
			timvitri(k,giua+1,phai);
		}
	}
}

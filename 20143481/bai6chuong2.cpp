#include <iostream>
using namespace std;
void nhap(int A[],int &n);
void ghep(int A[],int nA,int B[],int nB,int C[],int &nC);

int main()
{
	int A[100],nA,B[100],nB,C[200],nC;
	nhap(A,nA);
	nhap(B,nB);
	ghep(A,nA,B,nB,C,nC);
	for(int i=0;i<nC;i++)
	{
		cout << C[i] << " ";
	}
	return 0;
}
void nhap(int A[],int &n)
{
	cin >> n;
	for(int i=0;i<n;i++)
	{
		cin >> A[i];
	}
}
void ghep(int A[],int nA,int B[],int nB,int C[],int &nC)
{
	nC=0;
	int iA=0;
	int iB=0;
	while(iA<nA && iB<nB)
	{
		C[nC++]=A[iA++];
		C[nC++]=B[iB++];
	}
	while(iA<nA)
	{
		C[nC++]=A[iA++];
	}
	while(iB<nB)
	{
		C[nC++]=B[iB++];
	}
}

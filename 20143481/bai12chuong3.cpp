#include <iostream>
#include<string.h>
using namespace std;
void chia2so(char A[],char KQ[]);
void chuanhoa(char S1[],char S2[]);
void tong(char S1[],char S2[],char S3[]);
void tich(char A[],char B[],char C[]);

int main()
{
	char N[100],B[100],C[100],D[200],A[200],KQ[200];
	char so1[11]="0";
	gets(N);
	chuanhoa(N,so1);
	tong(N,so1,B);
	strrev(so1);
	tong(B,so1,C);
	strrev(N);
	strrev(B);
	tich(N,B,D);
	tich(D,C,A);
	chia2so(A,KQ);
	cout << KQ;
	return 0;
}
void chen(char S[],int sochen)
{
	strrev(S);
	int l=strlen(S);
	for(int i=0;i<sochen;i++)
	{
		S[l+i]='0';
	}
	S[l+sochen]='\0';
	strrev(S);
}
void chuanhoa(char S1[],char S2[])
{
	S2[strlen(S2)-1]='1';
	int l1=strlen(S1);
	int l2=strlen(S2);
	if(l1>l2)
	{
		chen(S2,l1-l2);
	}
	else 
	{
		chen(S1,l2-l1);
	}
}
void tong(char S1[],char S2[],char S3[])
{
	strrev(S1);
	strrev(S2);
	int nho=0;
	int n = strlen(S1);
	for(int i=0;i<n;i++)
	{
		int t = (S1[i]-'0')+(S2[i]-'0')+nho;
		if(t>=10)
		{
			S3[i]=t-10+'0';
			nho=1;
		}
		else
		{
			S3[i]=t+'0';
			nho=0;
		}
	}
	if(nho==1)
	{
		S3[n++]='1';
	}
	S3[n]='\0';
	strrev(S3);
}
void tich(char A[],char B[],char C[])
{
	strrev(A);
	strrev(B);
	int lenA = strlen(A);
	int lenB = strlen(B);
	for(int i=0;i<lenA+lenB;i++)
	{
		C[i]='0';
	}
	for(int iB=0;iB<lenB;iB++)
	{
		int nho=0;
		int iA;
		for(iA=0;iA<lenA;iA++)
		{
			int x = (B[iB]-'0')*(A[iA]-'0')+nho+(C[iA+iB]-'0');
			C[iA+iB]=x%10 +'0';
			nho = x/10;
		}
		if(nho>0)
		{
			C[iA+iB]=nho+'0';
		}
	}
	if(C[lenA+lenB-1]!='0')
	{
		C[lenA+lenB]='\0';
	}
	else
	{
		C[lenA+lenB-1]='\0';
	}
	strrev(C);
}
void xoaso0dau(char KQ[])
{
	strrev(KQ);
	int i=strlen(KQ)-1;
	while(i>=0 && KQ[i]=='0')
	{
		i--;
	}
	KQ[i+1]='\0';
	strrev(KQ);
}
void chia2so(char A[],char KQ[])
{
	int n=0;
	int i=0;
	long long number =0;
	while(i<strlen(A))
	{
		number = number*10+(A[i]-'0');
		KQ[n++]=number/6 +'0';
		number = number%6;
		i++;
	}
	KQ[n]='\0';
	xoaso0dau(KQ);
}

#include <iostream>
#include <string.h>
using namespace std;
void tong(char S1[],char S2[],char S3[]);
void chuanhoa(char S1[],char S2[]);
void tinhhieu(char S1[],char S2[],char S3[]);
void hieulontrube(char S1[],char S2[],char S3[]);

int main()
{
	char S1[20],S2[20],S3[21],S4[20],S5[20],S6[21];
	gets(S1);
	gets(S2);
	strcpy(S4,S1);
	strcpy(S5,S2);
	chuanhoa(S1,S2);
	chuanhoa(S4,S5);
	tong(S1,S2,S3);
	cout <<S3 << endl;
	tinhhieu(S4,S5,S6);
	cout <<S6 << endl;
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
void tinhhieu(char S1[],char S2[],char S3[])
{
	if(strcmp(S1,S2)>0)
	{
		hieulontrube(S1,S2,S3);
	}
	else 
	{
		hieulontrube(S2,S1,S3);
		int n=strlen(S3);
		strrev(S3);
		S3[n]='-';
		S3[n+1]='\0';
		strrev(S3);
	}
}
void hieulontrube(char S1[],char S2[],char S3[])
{
	strrev(S1);
	strrev(S2);
	int nho=0;
	int n = strlen(S1);
	for(int i=0;i<n;i++)
	{
		int t = (S1[i]-'0')-(S2[i]-'0')-nho;
		if(t<0)
		{
			S3[i]=t+10+'0';
			nho=1;
		}
		else
		{
			S3[i]=t+'0';
			nho=0;
		}
	}
	S3[n]='\0';
	strrev(S3);
}

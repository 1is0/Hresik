#include "pch.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>

/*Разработать программу, меню которой позволяет выполнить следующие функции:
* 1. Вввод даты (число, месяц, год)
* 2. Ввод даты в форме: 1 января 2010
* 3. Ввод даты в форме: 01.01.2010
* 4. Вычисление порядкового номера дня в году
* 5. Вывод количества дней, прошедших от Рождества Христова до введёной даты
* 6. Вычисление по дате дня недели
* 7. Информация о версии и авторе программы                                           
* 8. Выход из программы
*/

int Kod_Month(int kod_month, int month);
int Dw(int dw);
int Year(int month,int d, int y);
int Month(char *s_month, int month);

int main()
{
	setlocale(LC_ALL, "Rus");
	int year = 0, month = 0, day = 0, dw, ch;
	int d = 0, S = 0, kod_month = 0, kod_year = 0;
	char s_month[10], ch_1;

	printf("Choose date input method:\n");
	printf("1) day month year \n");
	printf("2) 1 january 2010 \n");
	printf("3) 01.01.2010 \n");
	printf("Or:\n");
	printf("7) Information about the version and author of the program\n");
	printf("8) Exit from the program\n\n");

	scanf_s("%d", &ch);
	if (ch != 1 && ch != 2 && ch != 3 && ch != 7 && ch != 8) {
		printf("ERROR\n");
		return 0;
	}

	switch (ch)
	{
	case 1: {	
		printf("\nInput day:\t\t\t\t");
		scanf_s("%d", &day);

		printf("Month (numbers only):\t\t\t");
		scanf_s("%d", &month);

		printf("Year:\t\t\t\t\t");
		scanf_s("%d", &year);
		if (day > 31 || month > 12) {
			printf("ERROR\n");
		return 0;
		}
		break; 
	}
	case 2: {
		printf("\nInput day, month(letters only), year:  ");
		scanf_s("%d%s%d", &day, &s_month, 10, &year);

		month = Month(s_month, month); 
		if (day > 31 || month > 12) {
			printf("ERROR\n");
			return 0;
		}
		break;
	}
	case 3: {
		printf("\nInput day, month, year:  \t\t");
		scanf_s("%d.%d.%d", &day, &month, &year);
		if (day > 31 || month > 12) {
			printf("ERROR\n");
			return 0;
		}
		break;
	}
	case 7: {
		printf("\n\t\t\t0.1 \tБГУИР\n");
		printf("\t\t\t\tКСиС\n");
		printf("\t\t\t\tИиТП\n");
		printf("\t\t\t\tгруппа 953502\n");
		printf("\t\t\t\tГресик Мария\n");
	
		break; 
	}
	case 8: {
	return 0;		
	}
	default: {
		printf("ERROR\n");
		break;
	}
	}

	int y = year;

	d = Year(month, d, y);

	printf("\n4) Serial number of days in a year: \t%d\n", (d + day));
	for (int i = 1; i <= year; ++i) {
		if (i % 4 == 0) {
				S = S + 366;
		}
		else
			S = S + 365;
	}	

	printf("\n5) Number of days from AD started:\t%d\n", S + d + day);

	kod_month = Kod_Month(kod_month, month);

	int chislo = (year % 100) / 4;
	
	kod_year = (6 + (year % 100) + chislo) % 7;
	
	dw = (day + kod_month + kod_year) % 7;
	dw = Dw(dw);

	return 0;
}

int Kod_Month(int kod_month, int month) {
	if (month == 1 || month == 10)
		kod_month = 1;
	else if (month == 5)
		kod_month = 2;
	else if (month == 8)
		kod_month = 3;
	else if (month == 2 || month == 3 || month == 11)
		kod_month = 4;
	else if (month == 6)
		kod_month = 5;
	else if (month == 12 || month == 9)
		kod_month = 6;
	else if (month == 4 || month == 7)
		kod_month = 0;
	return kod_month;
} 

int Dw(int dw) {	
	if (dw == 0) {
		dw = 6;
		printf("\n6) Weekday:\t\t\t\t%d - saturday\n", dw);
		return dw;
	}
	if (dw == 1) {
		dw = 7;
		printf("\n6) Weekday:\t\t\t\t%d - sunday\n", dw);
		return dw;
	}
	if (dw == 2) {
		dw = 1;
		printf("\n6) Weekday:\t\t\t\t%d - monday\n", dw);
		return dw;
	}
	if (dw == 3) {
		dw = 2;
		printf("\n6) Weekday:\t\t\t\t%d - tuesday\n", dw);
		return dw;
	}
	if (dw == 4) {
		dw = 3;
		printf("\n6) Weekday:\t\t\t\t%d - wednesday\n", dw);
		return dw;
	}
	if (dw == 5) {
		dw = 4;
		printf("\n6) Weekday:\t\t\t\t%d - thursday\n", dw);
		return dw;
	}
	if (dw == 6) {
		dw = 5;
		printf("\n6) Weekday:\t\t\t\t%d - friday\n", dw);
		return dw;
	}
}

int Year(int month, int d, int y) {
	for (int m = 1; m < month; ++m) {
		if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12) {
			d += 31;
		}
		if (m == 4 || m == 6 || m == 9 || m == 11) {
			d += 30;
		}
		if (m == 2) {
			if (y % 4 == 0) {
				d += 29;
			}
			else
				d += 28;
		}
	}
	return d;
}

int Month(char *s_month, int month)  { 
	if (strcmp(s_month, "january") == 0)
		month = 1;
	if (strcmp(s_month, "february") == 0)	
		month = 2;
	if (strcmp(s_month, "march") == 0)	
		month = 3;
	if (strcmp(s_month, "april") == 0)
		month = 4;
	if (strcmp(s_month, "may") == 0)
		month = 5;
	if (strcmp(s_month, "june") == 0)
		month = 6;
	if (strcmp(s_month, "july") == 0)
		month = 7;
	if (strcmp(s_month, "august") == 0)
		month = 8;
	if (strcmp(s_month, "september") == 0)
		month = 9;
	if (strcmp(s_month, "october") == 0)
		month = 10;
	if (strcmp(s_month, "november") == 0)
		month = 11;
	if (strcmp(s_month, "december") == 0)
		month = 12;
	return month;
}    
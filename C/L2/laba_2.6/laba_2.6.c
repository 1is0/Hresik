#include "pch.h"
#include <stdio.h>
#include <conio.h>
#include <math.h>

int main() {
	setlocale(0, "RUS");
	int i, n, k1, k2, fact = 1;
	float sx = 0, yx = 0, x, epsilon;
	// объявление указателя и присвоение указателю адрес ппеременной sx
	printf("Погрешность= \t");
	scanf_s("%f", &epsilon);
	printf( "Количество членов ряда= \t");
	scanf_s("%d",&n);
	if (n >= 0) {
		printf("Количество чисел= \t");
		scanf_s("%d",&k1);
	
		k2 = 0;
		float rs = 0;
		while (k2 < k1) {
			printf("\nx= ");
			scanf_s("%f", &x);
			if (x >= 0.1 || x < 1) {
				for (i = 1, fact = 1, sx = 0; i < 2 * n; i++) {
					
					fact *= (2 * i) - 1;
					sx += powl(-1, i - 1) * powl(x, (2 * i) - 1) / fact;
					rs = (sin(x) - sx);
					if (rs > epsilon) {
						printf("\nn = %d", i);
					}
					
				}
				
			}
			else {
				printf("Ошибка!");
				break;
			}
			yx = sin(x);			
			printf("\nsx= %f\n", sx);
			printf("yx= %f\n", yx);			
			k2++;
			
		}
	}
	else {
		printf("Ошибка\n");
	}
	return 0;
}
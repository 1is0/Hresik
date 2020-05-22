#include "pch.h"
#include <stdio.h>
#include <stdlib.h>

unsigned int calcSumNumber(unsigned int num) {
	if (num < 10)
		return num;
	else
		return num % 10 + calcSumNumber(num / 10);
}

int main() {
	int a;
	for (unsigned int i = 10; i <= 99; ++i) {
		int z = 0;

		for (unsigned int j = 2; j <= 9; ++j) {
			if (calcSumNumber(i) == calcSumNumber(i * j)) {
				z++;
				if (z == 8) {
					printf("\n");
					for (unsigned int j = 2; j <= 9; ++j) {

						if (calcSumNumber(i) == calcSumNumber(i * j)) {							
							printf("sum %d = sum %d * %d = sum %d\n", i, i, j, i * j);
						}
					}
				}
			}
		}
	}
	scanf_s("%d", &a);
	return 0;
}
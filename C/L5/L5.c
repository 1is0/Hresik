#include "pch.h"
#include <stdio.h>
#include <stdlib.h>
#define N 12

struct LNode {  
	int key;
	struct LNode *next;
};

struct List { // очередь
	struct LNode *forward, *back;
};

struct List *queue() {
	struct List *m = (struct List *)malloc(sizeof(struct List));
	m->forward = m->back = NULL;
	return m;
}

struct LNode *newNode(int k){
	struct LNode *temp = (struct LNode *)malloc(sizeof(struct LNode));
	temp->key = k;
	temp->next = NULL;
	return temp;
}

void Push(struct List *m, int k) { // добавление
	struct LNode* temp = newNode(k);
	if (m->back == NULL) {
		m->forward = m->back = temp;
		return;
	}
	if (m->forward == NULL) {
		m->back = m->forward = temp;
		return;
	}
	m->back->next = temp;
	m->back = temp;
}

void Pop(struct List* m) {    // удаление

	if (m->forward == NULL)
		return;

	struct LNode* temp = m->forward;
	m->forward = m->forward->next;

	if (m->forward == NULL)
		m->back = NULL;

	free(temp);
}

int main() {
	system("chcp 1251");
	system("cls");
	struct List *first = queue();
	struct List *second = queue();
	int number[N];

	printf("Изначальная очередь\n");
	for (int i = 0; i < N-1; i++) {
		Push(first, i );
	}

	for (int i = 0; i < N-1; i++) {
		number[i] = first->forward->key;
		printf("\t");
		printf("%d", number[i]);
		Pop(first);
	}

//------------------------------------------------------------
	//разделение очередей
	printf("\n\n");
	for (int y = 0; y < N-1; y++) {	
		printf("\t");
		printf("|");
	}
	printf("\n\n");
//------------------------------------------------------------

	for (int i = N-1; i-- > 0; ) {
		int t = number[i];
		Push(second, t);
	}
		
	for (int i = N-1; i > 0; i--) {
		number[i] = second->forward->key;
		printf("\t");
		printf("%d", number[i]);		
		Pop(second);
	}
	printf("\nИнвертированная  очередь\n");
	int s;
	scanf("%d",&s );
	return 0;
}
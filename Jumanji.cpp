//Jerome Reaux Jr.

#include <iostream>
#include <string>
using namespace std;
int main() {
  std::cout<< "Input Number" << std::endl;
  int InputNumber;
  std::cin >> InputNumber;
  std::cout << "The number of assignments you've failed is: " << InputNumber << std::endl;

std::cout<< "Input Letter" << std::endl;
  char InputLetter;
  std::cin >> InputLetter;
  std::cout << "Do better! The grade you got on your failed assignment(s) was: " << InputLetter << std::endl;
  
  std::cout<< "Quiz Answer" << std::endl;
  string QuizAnswer;
  std::cin >> QuizAnswer;
  std::cout << "Your Answer was: " << QuizAnswer << std::endl;
  cout<<"Since your answer was somewhat close you'll get partial credit, but you still failed."<<endl;
  
    int score = 11;
  cout << "Your quiz score:" << score << endl; 
  //Changing the score
  score = score + 5;
  cout << "The teacher felt bad about your score so raised by 5, now you score is:\n" << score << endl;
  //Combing with assigned operater
  score += 60;
    cout<< "After Being yelled at by your parents the teacher rose the score again:\n" <<score <<endl;
  cout<<"Congratulation You Passes!!!"<<endl;
    return 0;
}
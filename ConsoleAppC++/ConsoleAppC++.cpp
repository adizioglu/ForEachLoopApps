#include <iostream>
#include <vector>
#include <sstream>

int main() {
    std::string data = "Tim,Sue,Bob,Jane";
    std::vector<std::string> firstNames;
    std::stringstream ss(data);
    std::string name;

    while (std::getline(ss, name, ',')) {
        firstNames.push_back(name);
    }

    for (const auto& firstName : firstNames) {
        std::cout << firstName << std::endl;
    }

    return 0;
}

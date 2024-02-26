#include <iostream>
#include <string>
#include <memory>

class TreeNode {
public:
    char label;
    std::shared_ptr<TreeNode> left;
    std::shared_ptr<TreeNode> right;

    TreeNode(char label) : label(label), left(nullptr), right(nullptr) {}
};

class SyntaxAnalyzer {
private:
    std::string input;
    size_t position;
    std::shared_ptr<TreeNode> root;

    bool match(char expected) {
        if (position < input.length() && input[position] == expected) {
            position++;
            return true;
        }
        return false;
    }

    std::shared_ptr<TreeNode> createNode(char label) {
        return std::make_shared<TreeNode>(label);
    }

    std::shared_ptr<TreeNode> G() {
        if (match('(')) {
            auto node = createNode('G');
            node->left = M();
            if (match(')')) {
                return node;
            }
        }
        return nullptr;
    }

    std::shared_ptr<TreeNode> M() {
        auto node = createNode('M');
        node->left = Y();
        node->right = Z();
        return node;
    }

    std::shared_ptr<TreeNode> Y() {
        auto node = createNode('Y');
        if (match('a') || match('b')) {
            node->left = createNode(input[position - 1]);
        } else if (input[position] == '(') {
            node->left = G();
        }
        return node;
    }

    std::shared_ptr<TreeNode> Z() {
        auto node = createNode('Z');
        if (match('*') || match('-') || match('+')) {
            node->left = createNode(input[position - 1]);
            node->right = M();
        }
        return node;
    }

public:
    SyntaxAnalyzer(const std::string& input) : input(input), position(0), root(nullptr) {}

    std::shared_ptr<TreeNode> analyze() {
        root = G();
        return root;
    }

    void printTree(std::shared_ptr<TreeNode> node, int depth = 0) {
        if (node == nullptr) return;
        for (int i = 0; i < depth; ++i) {
            std::cout << "  ";
        }
        std::cout << node->label << std::endl;
        printTree(node->left, depth + 1);
        printTree(node->right, depth + 1);
    }
};

int main() {
    std::string input = "((a-b)*(a+b))";
    SyntaxAnalyzer analyzer(input);
    auto root = analyzer.analyze();

    if (root != nullptr) {
        std::cout << "Accepted" << std::endl;
        std::cout << "Parse Tree:" << std::endl;
        analyzer.printTree(root);
    } else {
        std::cout << "Rejected" << std::endl;
    }

    system("pause");
    return 0;
}

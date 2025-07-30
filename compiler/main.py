from lexer import tokenize
from parser import parse
from interpreter import execute
import sys

code = sys.stdin.read()
tokens = tokenize(code)
ast = parse(tokens)
execute(ast)

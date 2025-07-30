def execute(ast):
    for line in ast:
        if line.startswith("print("):
            content = line[6:-1]
            print(content)
        # Add full NIGHTX syntax support here

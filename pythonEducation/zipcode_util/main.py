from pythonEducation.zipcode_util import functions

commands_list = ["loc", "zip", "dist", "end"]
command = ""

while command != "end":
    print("\nCommand (", ", ".join(commands_list), ") => ")
    command = input().lower()
    if command == "loc":
        functions.write_loc()
    elif command == "zip":
        functions.zip()
    elif command == "dist":
        functions.dist()
    elif command not in commands_list:
        print("Invalid command, ignoring")
print("Done")

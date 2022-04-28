def input_to_list():
    empty_line = True
    while empty_line:
        input_string = input("Введiть рядок з словами \n")
        if input_string is not None:
            empty_line = False
    list_of_words = input_string.split(" ")
    return list_of_words


def display_sorted_list(list_of_words):
    list_of_words.sort()
    for word in list_of_words:
        print(word, end=" ")


words = input_to_list()
display_sorted_list(words)

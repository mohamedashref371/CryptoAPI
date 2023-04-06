Module Document
    Function Document(n As Integer) As String
        If n = 0 Then
            Return "Caesar Cipher (Shift Cipher):
It is a mono-alphabetic cipher wherein each letter of the plaintext is substituted by another letter to form the ciphertext. It is a simplest form of substitution cipher scheme.
This cryptosystem is generally referred to as the Shift Cipher. The concept is to replace each alphabet by another alphabet which is ‘shifted’ by some fixed number between 0 and 25.
For this type of scheme, both sender and receiver agree on a ‘secret shift number’ for shifting the alphabet. This number which is between 0 and 25 becomes the key of encryption.
The name ‘Caesar Cipher’ is occasionally used to describe the Shift Cipher when the ‘shift of three’ is used.

Security Value:
Caesar Cipher is not a secure cryptosystem because there are only 26 possible keys to try out.
An attacker can carry out an exhaustive key search with available limited computing resources."
        ElseIf n = 1 Then
            Return "Simple Substitution Cipher:
It is an improvement to the Caesar Cipher. Instead of shifting the alphabets by some number, this scheme uses some permutation of the letters in alphabet.
For example, A.B…..Y.Z and Z.X……B.A are two obvious permutation of all the letters in alphabet. Permutation is nothing but a jumbled up set of alphabets.
With 26 letters in alphabet, the possible permutations are 26! (Factorial of 26) which is equal to 4x1026. The sender and the receiver may choose any one of these possible permutation as a ciphertext alphabet. This permutation is the secret key of the scheme.

Security Value:
The possible number of keys is large (26!) and even the modern computing systems are not yet powerful enough to comfortably launch a brute force attack to break the system. However, the Simple Substitution Cipher has a simple design and it is prone to design flaws, say choosing obvious permutation, this cryptosystem can be easily broken."
        ElseIf n = 2 Then
            Return "Playfair Cipher:
In this scheme, pairs of letters are encrypted, instead of single letters as in the case of simple substitution cipher.
In playfair cipher, initially a key table is created. The key table is a 5×5 grid of alphabets that acts as the key for encrypting the plaintext. Each of the 25 alphabets must be unique and one letter of the alphabet (usually J) is omitted from the table as we need only 25 alphabets instead of 26. If the plaintext contains J, then it is replaced by I.
The sender and the receiver deicide on a particular key, say ‘tutorials’. In a key table, the first characters (going left to right) in the table is the phrase, excluding the duplicate letters. The rest of the table will be filled with the remaining letters of the alphabet, in natural order.

Security Value:
It is also a substitution cipher and is difficult to break compared to the simple substitution cipher. As in case of substitution cipher, cryptanalysis is possible on the Playfair cipher as well, however it would be against 625 possible pairs of letters (25x25 alphabets) instead of 26 different possible alphabets.
The Playfair cipher was used mainly to protect important, yet non-critical secrets, as it is quick to use and requires no special equipment."
        ElseIf n = 3 Then
            Return "Vigenère Cipher:
This scheme of cipher uses a text string (say, a word) as a key, which is then used for doing a number of shifts on the plaintext.
For example, let’s assume the key is ‘point’. Each alphabet of the key is converted to its respective numeric value: In this case,
       p -> 16, o -> 15, i -> 9, n -> 14, and t -> 20.
Thus, the key is: 16 15 9 14 20.

Security Value:
Vigenere Cipher was designed by tweaking the standard Caesar cipher to reduce the effectiveness of cryptanalysis on the ciphertext and make a cryptosystem more robust. It is significantly more secure than a regular Caesar Cipher.
In the history, it was regularly used for protecting sensitive political and military information. It was referred to as the unbreakable cipher due to the difficulty it posed to the cryptanalysis.

Variants of Vigenère Cipher:
There are two special cases of Vigenère cipher:
- The keyword length is same as plaintect message. This case is called Vernam Cipher. It is more secure than typical Vigenere cipher.
- Vigenère cipher becomes a cryptosystem with perfect secrecy, which is called One-time pad.

One-Time Pad:

The circumstances are:
- The length of the keyword is same as the length of the plaintext.
- The keyword is a randomly generated string of alphabets.
- The keyword is used only once.

Security Value:
Let us compare Shift cipher with one-time pad.

Shift Cipher: Easy to Break
In case of Shift cipher, the entire message could have had a shift between 1 and 25. This is a very small size, and very easy to brute force. However, with each character now having its own individual shift between 1 and 26, the possible keys grow exponentially for the message.

One-time Pad: Impossible to Break
Let us say, we encrypt the name "“point”" with a one-time pad. It is a 5 letter text. To break the ciphertext by brute force, you need to try all possibilities of keys and conduct computation for (26 x 26 x 26 x 26 x 26) = 265 = 11881376 times. That’s for a message with 5 alphabets. Thus, for a longer message, the computation grows exponentially with every additional alphabet. This makes it computationally impossible to break the ciphertext by brute force."
        ElseIf n = 4 Then
            Return "AutoKey is a cryptographic algorithm used for encryption and decryption of messages. It is a type of substitution cipher that uses a secret key to encrypt the plaintext message. AutoKey is a modification of the Vigenère cipher, which is a more basic version of the substitution cipher.

The AutoKey algorithm uses a secret key, which is a series of letters or numbers, to encrypt the plaintext message. The key is used to generate a series of key letters, which are then used to encrypt the message. The key letters are generated by taking the first letter of the secret key and appending it to the plaintext message. This process is repeated until the entire plaintext message has been encrypted.

For example, if the secret key is ""SECRET"" and the plaintext message is ""HELLO"", the key letters would be ""SHELO"". To encrypt the message, the first letter of the plaintext message is added to the first letter of the key letters, which gives the first letter of the ciphertext message. This process is repeated for each letter of the plaintext message. If the end of the key letters is reached before the end of the plaintext message, the process starts over from the beginning of the key letters.

AutoKey is a relatively simple encryption algorithm that can be easily implemented using basic programming techniques. However, it is not considered to be a secure method of encryption, as it can be easily broken using frequency analysis or other cryptanalytic techniques.

To improve the security of the AutoKey algorithm, several modifications have been proposed, such as the use of a random key instead of a secret key, or the use of a different encryption method for the first few letters of the plaintext message.

In summary, AutoKey is a cryptographic algorithm used for encryption and decryption of messages. It is a type of substitution cipher that uses a secret key to encrypt the plaintext message. While it is a relatively simple encryption algorithm, it is not considered to be a secure method of encryption, and should not be used for sensitive or confidential information."
        ElseIf n = 5 Then
            Return "Transposition Cipher:

It is another type of cipher where the order of the alphabets in the plaintext is rearranged to create the ciphertext. The actual plaintext alphabets are not replaced.

An example is a ‘simple columnar transposition’ cipher where the plaintext is written horizontally with a certain alphabet width. Then the ciphertext is read vertically as shown.

For example, the plaintext is "“golden statue is in eleventh cave”" and the secret random key chosen is "“five”". We arrange this text horizontally in table with number of column equal to key value.

The ciphertext is obtained by reading column vertically downward from first to last column. The ciphertext is ‘gnuneaoseenvltiltedasehetivc’.

To decrypt, the receiver prepares similar table. The number of columns is equal to key number. The number of rows is obtained by dividing number of total ciphertext alphabets by key value and rounding of the quotient to next integer value.

The receiver then writes the received ciphertext vertically down and from left to right column. To obtain the text, he reads horizontally left to right and from top to bottom row."
        ElseIf n = 6 Then
            Return "The Data Encryption Standard (DES) is a symmetric-key block cipher published by the National Institute of Standards and Technology (NIST).
DES is an implementation of a Feistel Cipher. It uses 16 round Feistel structure. The block size is 64-bit. Though, key length is 64-bit, DES has an effective key length of 56 bits, since 8 of the 64 bits of the key are not used by the encryption algorithm (function as check bits only).

Since DES is based on the Feistel Cipher, all that is required to specify DES is:
- Round function
- Key schedule
- Any additional processing – Initial and final permutation

The DES satisfies both the desired properties of block cipher. These two properties make cipher very strong.
- Avalanche effect: A small change in plaintext results in the very grate change in the ciphertext.
- Completeness: Each bit of ciphertext depends on many bits of plaintext.
During the last few years, cryptanalysis have found some weaknesses in DES when key selected are weak keys. These keys shall be avoided.
DES has proved to be a very well designed block cipher. There have been no significant cryptanalytic attacks on DES other than exhaustive key search. "
        ElseIf n = 7 Then
            Return "3-KEY Triple DES:
The speed of exhaustive key searches against DES after 1990 began to cause discomfort amongst users of DES. However, users did not want to replace DES as it takes an enormous amount of time and money to change encryption algorithms that are widely adopted and embedded in large security architectures.
The pragmatic approach was not to abandon the DES completely, but to change the manner in which DES is used. This led to the modified schemes of Triple DES (sometimes known as 3DES).
Incidentally, there are two variants of Triple DES known as 3 key Triple DES (3TDES) and 2-key Triple DES (2TDES).

Before using 3TDES, user first generate and distribute a 3TDES key K, which consists of three different DES keys K1, K2 and K3. This means that the actual 3TDES key has length 3×56 = 168 bits. 

The encryption-decryption process is as follows:
- Encrypt the plaintext blocks using single DES with key K1.
- Now decrypt the output of step 1 using single DES with key K2.
- Finally, encrypt the output of step 2 using single DES with key K3.
- The output of step 3 is the ciphertext.
- Decryption of a ciphertext is a reverse process. User first decrypt using K3,
then encrypt with K2, and finally decrypt with K1.

Due to this design of Triple DES as an encrypt–decrypt–encrypt process, it is possible to use a 3TDES (hardware) implementation for single DES by setting K1, K2, and K3 to be the same value. This provides backwards compatibility with DES.
Second variant of Triple DES (2TDES) is identical to 3TDES except that K3 is replaced by K1. In other words, user encrypt plaintext blocks with key K1, then decrypt with key K2, and finally encrypt with K1 again. Therefore, 2TDES has a key length of 112 bits.
Triple DES systems are significantly more secure than single DES, but these are clearly a much slower process than encryption using single DES."
        ElseIf n = 8 Then
            Return "ADVANCED ENCRYPTION STANDARD (AES):
The more popular and widely adopted symmetric encryption algorithm likely to be encountered nowadays is the Advanced Encryption Standard (AES). It is found at least six time faster than triple DES.
A replacement for DES was needed as its key size was too small. With increasing computing power, it was considered vulnerable against exhaustive key search attack. Triple DES was designed to overcome this drawback but it was found slow.
The features of AES are as follows:
- Symmetric key symmetric block cipher
- 128-bit data, 128/192/256-bit keys
- Stronger and faster than Triple-DES
- Provide full specification and design details
- Software implementable in C and Java

Operation of AES:
AES is an iterative rather than Feistel cipher. It is based on ‘substitution–permutation network’. It comprises of a series of linked operations, some of which involve replacing inputs by specific outputs (substitutions) and others involve shuffling bits around (permutations).
Interestingly, AES performs all its computations on bytes rather than bits. Hence, AES treats the 128 bits of a plaintext block as 16 bytes. These 16 bytes are arranged in four columns and four rows for processing as a matrix.
Unlike DES, the number of rounds in AES is variable and depends on the length of the key. AES uses 10 rounds for 128-bit keys, 12 rounds for 192-bit keys and 14 rounds for 256-bit keys. Each of these rounds uses a different 128-bit round key,
which is calculated from the original AES key.

AES Analysis
:
In present day cryptography, AES is widely adopted and supported in both hardware and software. Till date, no practical cryptanalytic attacks against AES has been discovered. Additionally, AES has built-in flexibility of key length, which allows a degree of ‘future-proofing’ against progress in the ability to perform exhaustive key searches.
However, just as for DES, the AES security is assured only if it is correctly implemented and good key management is employed."
        ElseIf n = 9 Then
            Return "A hash function is a mathematical function that takes in an input (or a ""key"") and computes a fixed-size output (or a ""hash value"") that represents the input in a unique and reproducible way. Hash functions are widely used in computer science and cryptography for various purposes such as data indexing, data structures, message authentication, and digital signatures.

In this article, we will discuss the properties and applications of hash functions, as well as some common hash functions used in practice.

Properties of Hash Functions:
A good hash function should have the following properties:

Deterministic:
A hash function must produce the same hash value for the same input every time it is called. This is essential for the reproducibility of hash values, which is necessary for many applications such as data indexing and message authentication.

Uniformity:
A hash function should distribute the hash values uniformly across its output range. That is, each possible hash value should have approximately the same number of input values that produce it. This property is important for avoiding collisions, which occur when two different inputs produce the same hash value.

Non-reversibility:
A hash function should be computationally infeasible to reverse, that is, given a hash value, it should be difficult to find an input that produces it. This property is important for message authentication and digital signatures, where the hash value serves as a fingerprint of the message that can be verified without revealing the message itself.

Sensitivity to Input Changes:
A good hash function should produce a completely different hash value for even a small change in the input. This is important for avoiding collisions and for maintaining the integrity and confidentiality of the data.

Applications of Hash Functions:
Hash functions have many applications in computer science and cryptography, including:

Data Indexing:
Hash functions are used in data indexing to map keys to indexes in an array or a hash table. The hash value serves as the index of the key in the data structure, which provides fast and efficient access to the data.

Data Structures:
Hash functions are used in various data structures such as hash tables, Bloom filters, and Merkle trees. These data structures rely on the uniformity and non-reversibility properties of hash functions to provide fast and efficient operations such as insertion, deletion, and lookup.

Message Authentication:
Hash functions are used in message authentication to ensure the integrity and authenticity of messages. A hash value of the message is computed using a hash function and then transmitted along with the message. The receiver of the message can verify the integrity and authenticity of the message by recomputing the hash value using the same hash function and comparing it to the transmitted hash value.

Digital Signatures:
Hash functions are used in digital signatures to provide non-repudiation and authenticity of digital documents. A digital signature is created by computing a hash value of the document using a hash function, and then encrypting the hash value using the sender's private key. The receiver of the document can verify the authenticity of the document by decrypting the encrypted hash value using the sender's public key and comparing it to the computed hash value.

Common Hash Functions:
There are many hash functions in use today, each with its own strengths and weaknesses. Some common hash functions include:

MD5:
MD5 (Message-Digest algorithm 5) is a widely used hash function that produces a 128-bit hash value. It is fast and efficient, but it has been found to be vulnerable to collision attacks and is no longer recommended for cryptographic purposes.

SHA-1:
SHA-1 (Secure Hash Algorithm 1) is a widely used hash function that produces a 160-bit hash value. It is slower than MD5 but provides better security and resistance to collision attacks. However, it has also been found to be vulnerable to attacks and is no longer recommended for cryptographic purposes.

SHA-256:
SHA-256 (Secure Hash Algorithm 256) is a widely used hash function that produces a 256-bit hash value. It is more secure and resistant to attacks than SHA-1 and is currently recommended for cryptographic purposes.

SHA-3:
SHA-3 (Secure Hash Algorithm 3) is a newer hash function that was selected as the winner of the NIST hash function competition in 2012. It provides better security and resistance to attacks than SHA-2, and is available in various output sizes ranging from 224 bits to 512 bits.

Conclusion:
Hash functions are an important tool in computer science and cryptography, providing fast and efficient operations for data indexing, data structures, message authentication, and digital signatures. A good hash function should have the properties of determinism, uniformity, non-reversibility, and sensitivity to input changes. There are many hash functions in use today, each with its own strengths and weaknesses, and it is important to choose the appropriate hash function for each application based on its security and performance requirements."
        End If
        Return ""
    End Function
End Module

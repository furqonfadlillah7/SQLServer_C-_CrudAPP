# Manajemen Basis Data
## Implementasi CRUD Microsoft SQL Server dengan C#
Link Video Persentasi => https://youtu.be/qA0pt2uLFt0

atau klik dibawah ini!

[![Build Status](https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white)](https://youtu.be/qA0pt2uLFt0)
## Kelompok 3
> Anggota Kelompok
> | NIM | Nama |
> | --- | --- |
> | 1207050072 | Muhammad Furqon Fadlilah |
> | 1207050073 | Muhammad Ghiyats Naufal |
> | 1207050083 | Muhammad Widianto |

## Microsoft SQL Server 
Microsoft SQL Server adalah sebuah sistem manajemen basis data relasional produk Microsoft. Bahasa kueri utamanya adalah Transact-SQL yang merupakan implementasi dari SQL standar ANSI/ISO yang digunakan oleh Microsoft dan Sybase.

## Tools yang digunakan
- Microsoft Visual Studio
- Microsoft SQL Server Management Studio

## Cara Setup

git clone https://github.com/furqonfadlillah7/SQLServer_C-_CrudAPP.git


## SQL Command
> 1. Insert
 insert into TableMhs values (@NIM,@Nama,@Jurusan) 

> 2. Edit
 Update TableMhs set Nama=@Nama, Jurusan=@Jurusan where NIM=@NIM  

> 3. Delete
 Delete TableMhs where NIM=@NIM 

> 4. Search / Read
 Select * from TableMhs where NIM=@NIM 

### Screenshoot Form 
<img width="409" alt="image" src="https://user-images.githubusercontent.com/78301902/209471732-3cb9cc83-a462-48b1-85bf-dfbddbf024d4.png">

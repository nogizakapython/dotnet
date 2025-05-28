:: Comment line starts with "::"
::
:: cd "{Python-script directory}"
:: python AutoScrubber_Main.py  "/{path}/{Project Infomation}.xlsx"
::  
:: if you want, you can add more lines to run mutliple Project Infomation files.

setlocal enabledelayedexpansion

:: 配列の定義
set array1=python-docs python-pptx pywin32 pandas openpyxl

:: 配列の中の要素を1個ずつ取り出してライブラリをインストールする
for %%i in (%array1%) do (
    pip list | findstr %%i
)
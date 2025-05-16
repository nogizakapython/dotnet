setlocal enabledelayedexpansion

:: 配列の定義
set array1=python-docs python-pptx pywin32 pandas openpyxl

:: 配列の中の要素を1個ずつ取り出してライブラリをインストールする
for %%i in (%array1%) do (
    pip install %%i
)

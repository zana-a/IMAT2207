# Building PDF from markdown

To build the markdown files into either word document, html, pdf or any other format, you can use `pandoc`. However, it is a little flimsy to use.

When you are done installing `pandoc`, you will need `pdflatex`. Best way to do this is by installing a set of tools called [MiKTex](https://miktex.org/) for windows or MacTex for MacOS.

The code provided at the bottom is a front-matter which tells how pandoc should compile the pdf. So far, this seems to be the best layout and will probably change as we progress.

```yaml
---
papersize: a4
linestretch: 1
toc: true
lot: true
classoption: oneside
header-includes: |
    \usepackage{fancyhdr}
    \pagestyle{fancy}
    \fancyhead[CO,CE]{}
    \fancyfoot[CO,CE]{}
    \fancyfoot[LE,RO]{\thepage}
geometry: a4paper, portrait, margin=1.25in

title: Folio
subtitle: An Ebook Retailer
author:
    - Zana Ahmad
    - Hugh Alun-Jones
    - Thomas Akers
    - Emmanuel Adedeji
---
```

Please copy and move the specification somewhere outside the repository to ensure the README.md is not affected or changed so that we have a general edit copy.

The command to run for pandoc is:

```bash
pandoc main.md -o main.pdf --top-level-division=chapter
```

Also, only run this command inside the folder where the markdown file is.

**I will also build them using my computer so don't worry if you cant get this working or you dont't want to.**

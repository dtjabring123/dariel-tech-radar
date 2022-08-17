from openpyxl import load_workbook
import csv
from pathlib import Path

filename = Path('data/technology-list.xlsx')

wb = load_workbook(filename = filename)

sheet = wb['Technologies']

byor_headers = {
        "Technology": "name",
        "Ring": "ring",
        "Quadrant": "quadrant",
        "Is New?": "isNew",
        "Description": "description",
        }


def make_description(row):
    """Reads the columns that form a description in the row and makes the description"""
    description = row[4] or ""
    description += "<br/>"
    description += f"<br/><strong>Vendor: </strong><em>{row[5] or ''}</em>"
    description += f"<br/><strong>Assessed by: </strong><em>{row[6] or ''}</em>"
    description += f"<br/><strong>Last assessment date: </strong><em>{row[7] or ''}</em>"
    description += f"<br/><strong>Customer demand: </strong><em>{row[8] or ''}</em>"
    description += f"<br/><strong>Should we adopt?: </strong><em>{row[9] or ''}</em>"
    description += f"<br/><strong>Value: </strong><em>{row[10] or ''}</em>"

    return description

def byor_row(row):
    """Converts a Technology list row into a Tech radar list"""
    print(row)
    name = row[0] or ""
    ring = row[1] or ""
    quadrant = row[2] or ""
    isNew = row[3] or ""
    description = make_description(row)

    return [name, ring, quadrant, isNew, description]

if __name__ == '__main__':
    with filename.with_suffix('.csv').open('w') as radar_file:
        radar_writer = csv.writer(radar_file, delimiter=',', quotechar='"', quoting=csv.QUOTE_MINIMAL)

        headers = [byor_headers[h.value] for h in sheet[1] if h.value in byor_headers.keys()]
        radar_writer.writerow(headers)

        rows = [byor_row(row) for row in sheet.values]
        radar_writer.writerows(rows[1:])

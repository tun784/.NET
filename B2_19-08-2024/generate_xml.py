import random
import xml.etree.ElementTree as ET

# Tạo phần tử gốc
root = ET.Element("Mang")

# Thêm 100 phần tử ngẫu nhiên
for _ in range(100):
    phan_tu = ET.SubElement(root, "PhanTu")
    phan_tu.text = str(random.randint(10, 99))

# Tạo đối tượng ElementTree
tree = ET.ElementTree(root)

# Ghi vào file XML
tree.write("Mang1chieu.xml", encoding="utf-8", xml_declaration=True)

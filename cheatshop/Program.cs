byte[] by = File.ReadAllBytes(args[0]);
var li = new List<byte>();
li = by.ToList();
int po1 = BitConverter.ToInt32(by, 196);
int po2 = BitConverter.ToInt32(by, po1 + 12);   //list

int katate = po2;
int dual = katate + 4;
int great = dual + 4;
int longs = great + 4;
int hammer = longs + 4;
int fue = hammer + 4;
int lance = fue + 4;
int gance = lance + 4;
int light = gance + 4;
int heavy = light + 4;
int bow = heavy + 4;

int head = po2 + 44;
int chest = po2 + 48;
int arms = po2 + +52;
int waist = po2 + 56;
int legs = po2 + 60;
byte[] zero = { 00, 00, 00, 00 };

var idList = File.ReadAllBytes("katate").ToList();
byte[] leng = BitConverter.GetBytes(li.Count);
li[katate] = leng[0];
li[katate + 1] = leng[1];
li[katate + 2] = leng[2];
li[katate + 3] = leng[3];
li.AddRange(idList);

idList = File.ReadAllBytes("swaxe").ToList();
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("dual").ToList();
leng = BitConverter.GetBytes(li.Count);
li[dual] = leng[0];
li[dual + 1] = leng[1];
li[dual + 2] = leng[2];
li[dual + 3] = leng[3];
li.AddRange(idList);

idList = File.ReadAllBytes("tonfa").ToList();
li.AddRange(idList);
li.AddRange(zero);


idList = File.ReadAllBytes("greawsword").ToList();
leng = BitConverter.GetBytes(li.Count);
li[great] = leng[0];
li[great + 1] = leng[1];
li[great + 2] = leng[2];
li[great + 3] = leng[3];
li.AddRange(idList);

idList = File.ReadAllBytes("ryuukon").ToList();
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("longsword").ToList();
leng = BitConverter.GetBytes(li.Count);
li[longs] = leng[0];
li[longs + 1] = leng[1];
li[longs + 2] = leng[2];
li[longs + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);


idList = File.ReadAllBytes("hammer").ToList();
leng = BitConverter.GetBytes(li.Count);
li[hammer] = leng[0];
li[hammer + 1] = leng[1];
li[hammer + 2] = leng[2];
li[hammer + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("fue").ToList();
leng = BitConverter.GetBytes(li.Count);
li[fue] = leng[0];
li[fue + 1] = leng[1];
li[fue + 2] = leng[2];
li[fue + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("lance").ToList();
leng = BitConverter.GetBytes(li.Count);
li[lance] = leng[0];
li[lance + 1] = leng[1];
li[lance + 2] = leng[2];
li[lance + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("gance").ToList();
leng = BitConverter.GetBytes(li.Count);
li[gance] = leng[0];
li[gance + 1] = leng[1];
li[gance + 2] = leng[2];
li[gance + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("light").ToList();
leng = BitConverter.GetBytes(li.Count);
li[light] = leng[0];
li[light + 1] = leng[1];
li[light + 2] = leng[2];
li[light + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("heavy").ToList();
leng = BitConverter.GetBytes(li.Count);
li[heavy] = leng[0];
li[heavy + 1] = leng[1];
li[heavy + 2] = leng[2];
li[heavy + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = File.ReadAllBytes("bow").ToList();
leng = BitConverter.GetBytes(li.Count);
li[bow] = leng[0];
li[bow + 1] = leng[1];
li[bow + 2] = leng[2];
li[bow + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);


idList = new List<byte>();
int ids = 14593;
for (int t = 1; t < ids + 1; t++)
{
    byte[] bh = { 0, 0 };
    byte[] b = BitConverter.GetBytes(t);
    bh[0] = b[0];
    bh[1] = b[1];
    idList.AddRange(bh);
}
leng = BitConverter.GetBytes(li.Count);
li[head] = leng[0];
li[head + 1] = leng[1];
li[head + 2] = leng[2];
li[head + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);


idList = new List<byte>();
ids = 13461;
for (int t = 1; t < ids + 1; t++)
{
    byte[] bh = { 0, 0 };
    byte[] b = BitConverter.GetBytes(t);
    bh[0] = b[0];
    bh[1] = b[1];
    idList.AddRange(bh);
}
leng = BitConverter.GetBytes(li.Count);
li[chest] = leng[0];
li[chest + 1] = leng[1];
li[chest + 2] = leng[2];
li[chest + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = new List<byte>();
ids = 13451;
for (int t = 1; t < ids + 1; t++)
{
    byte[] bh = { 0, 0 };
    byte[] b = BitConverter.GetBytes(t);
    bh[0] = b[0];
    bh[1] = b[1];
    idList.AddRange(bh);
}
leng = BitConverter.GetBytes(li.Count);
li[arms] = leng[0];
li[arms + 1] = leng[1];
li[arms + 2] = leng[2];
li[arms + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);


//wasit
idList = new List<byte>();
ids = 13707;
for (int t = 1; t < ids + 1; t++)
{
    byte[] bh = { 0, 0 };
    byte[] b = BitConverter.GetBytes(t);
    bh[0] = b[0];
    bh[1] = b[1];
    idList.AddRange(bh);
}
leng = BitConverter.GetBytes(li.Count);
li[waist] = leng[0];
li[waist + 1] = leng[1];
li[waist + 2] = leng[2];
li[waist + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);

idList = new List<byte>();
ids = 13513;
for (int t = 1; t < ids + 1; t++)
{
    byte[] bh = { 0, 0 };
    byte[] b = BitConverter.GetBytes(t);
    bh[0] = b[0];
    bh[1] = b[1];
    idList.AddRange(bh);
}
leng = BitConverter.GetBytes(li.Count);
li[legs] = leng[0];
li[legs + 1] = leng[1];
li[legs + 2] = leng[2];
li[legs + 3] = leng[3];
li.AddRange(idList);
li.AddRange(zero);


by = li.ToArray();
File.WriteAllBytes("mhfdat.bin", by);